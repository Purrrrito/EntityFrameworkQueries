using EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EntityFrameworkQueries
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSelectAllVendors_Click(object sender, EventArgs e)
		{
			using APContext dbContext = new();

			// LINQ (Langue Integrated Query) method syntax
			List<Models.Vendor> vendorList = dbContext.Vendors.ToList();

			// LINQ query syntax
			List<Models.Vendor> vendorList2 = (from v in dbContext.Vendors
											   select v).ToList();
		}

		private void btnAllCaliVendors_Click(object sender, EventArgs e)
		{
			using APContext dbcontext = new();

			List<Models.Vendor> vendorList = dbcontext.Vendors
												.Where(v => v.VendorState == "CA")
												.OrderBy(v => v.VendorName)
												.ToList();

			List<Models.Vendor> vendorList2 = (from v in dbcontext.Vendors
											   where v.VendorState == "CA"
											   orderby v.VendorName
											   select v).ToList();
		}

		private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
		{
			APContext dbContext = new();
			// Anonymous type
			List<VendorLocation> results = (from v in dbContext.Vendors
											select new VendorLocation
											{
												VendorName = v.VendorName,
												VendorState = v.VendorState,
												VendorCity = v.VendorCity
											}).ToList();

			StringBuilder displayString = new();
			foreach (VendorLocation vendor in results)
			{
				displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
			}

			MessageBox.Show(displayString.ToString());
		}

		private void btnMiscQueries_Click(object sender, EventArgs e)
		{
			APContext dbContext = new();

			// Check if something exists
			bool doesExist = (from v in dbContext.Vendors
							  where v.VendorState == "WA"
							  select v).Any();

			// Get the number of Invoices
			int invoiceCount = (from i in dbContext.Invoices
								select i).Count();

			// Query a single Vendor
			Vendor ? singleVendor = (from v in dbContext.Vendors
									 where v.VendorName == "Joe's Burger Shack"
									 select v).SingleOrDefault();

			if ( singleVendor != null )
			{
				// Do something with the Vendor object
			}
		}
	}

	class VendorLocation 
	{
        public string VendorName { get; set; }

        public string VendorState { get; set; }

		public string VendorCity { get; set; }
    }
}
