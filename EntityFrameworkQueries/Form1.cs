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
	}
}
