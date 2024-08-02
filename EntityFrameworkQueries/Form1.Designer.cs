namespace EntityFrameworkQueries
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnSelectAllVendors = new Button();
			btnAllCaliVendors = new Button();
			btnSelectSpecificColumns = new Button();
			btnMiscQueries = new Button();
			btnVendorsAndInvoices = new Button();
			SuspendLayout();
			// 
			// btnSelectAllVendors
			// 
			btnSelectAllVendors.Location = new Point(12, 26);
			btnSelectAllVendors.Name = "btnSelectAllVendors";
			btnSelectAllVendors.Size = new Size(178, 23);
			btnSelectAllVendors.TabIndex = 0;
			btnSelectAllVendors.Text = "SELECT * FROM Vendors";
			btnSelectAllVendors.UseVisualStyleBackColor = true;
			btnSelectAllVendors.Click += btnSelectAllVendors_Click;
			// 
			// btnAllCaliVendors
			// 
			btnAllCaliVendors.Location = new Point(12, 64);
			btnAllCaliVendors.Name = "btnAllCaliVendors";
			btnAllCaliVendors.Size = new Size(289, 23);
			btnAllCaliVendors.TabIndex = 1;
			btnAllCaliVendors.Text = "SELECT * FROM Vendors WHERE VendorState = 'CA'";
			btnAllCaliVendors.UseVisualStyleBackColor = true;
			btnAllCaliVendors.Click += btnAllCaliVendors_Click;
			// 
			// btnSelectSpecificColumns
			// 
			btnSelectSpecificColumns.Location = new Point(12, 103);
			btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
			btnSelectSpecificColumns.Size = new Size(356, 23);
			btnSelectSpecificColumns.TabIndex = 2;
			btnSelectSpecificColumns.Text = "SELECT VendorName, VendorCity, VendorState FROM Vendors";
			btnSelectSpecificColumns.UseVisualStyleBackColor = true;
			btnSelectSpecificColumns.Click += btnSelectSpecificColumns_Click;
			// 
			// btnMiscQueries
			// 
			btnMiscQueries.Location = new Point(12, 142);
			btnMiscQueries.Name = "btnMiscQueries";
			btnMiscQueries.Size = new Size(96, 23);
			btnMiscQueries.TabIndex = 3;
			btnMiscQueries.Text = "Misc. Queries";
			btnMiscQueries.UseVisualStyleBackColor = true;
			btnMiscQueries.Click += btnMiscQueries_Click;
			// 
			// btnVendorsAndInvoices
			// 
			btnVendorsAndInvoices.Location = new Point(22, 190);
			btnVendorsAndInvoices.Name = "btnVendorsAndInvoices";
			btnVendorsAndInvoices.Size = new Size(232, 23);
			btnVendorsAndInvoices.TabIndex = 4;
			btnVendorsAndInvoices.Text = "Select all Vendors with their Invoices";
			btnVendorsAndInvoices.UseVisualStyleBackColor = true;
			btnVendorsAndInvoices.Click += btnVendorsAndInvoices_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnVendorsAndInvoices);
			Controls.Add(btnMiscQueries);
			Controls.Add(btnSelectSpecificColumns);
			Controls.Add(btnAllCaliVendors);
			Controls.Add(btnSelectAllVendors);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnSelectAllVendors;
		private Button btnAllCaliVendors;
		private Button btnSelectSpecificColumns;
		private Button btnMiscQueries;
		private Button btnVendorsAndInvoices;
	}
}
