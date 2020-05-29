using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DataBindingDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DataBindingDemo.DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            button1.DataBindings.Add("Text",textBox1,"Text");
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet11);
            // textbook missing Close
            sqlConnection1.Close();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet11 = new DataBindingDemo.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT COUNT(*) AS NumOrders FROM Orders";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = @"INSERT INTO Orders(CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) VALUES (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry FROM Orders WHERE (OrderID = @@IDENTITY)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "UPDATE Orders SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, OrderDate =" +
                " @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, ShipVia =" +
                " @ShipVia, Freight = @Freight, ShipName = @ShipName, ShipAddress = @ShipAddress," +
                " ShipCity = @ShipCity, ShipRegion = @ShipRegion, ShipPostalCode = @ShipPostalCod" +
                "e, ShipCountry = @ShipCountry WHERE (OrderID = @Original_OrderID) AND (CustomerI" +
                "D = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL)" +
                " AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND Empl" +
                "oyeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AN" +
                "D Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate I" +
                "S NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Ori" +
                "ginal_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Origina" +
                "l_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (Shi" +
                "pCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) A" +
                "ND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND Shi" +
                "pCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NU" +
                "LL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Orig" +
                "inal_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Origi" +
                "nal_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (Ship" +
                "Via = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (S" +
                "hippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedD" +
                "ate IS NULL); SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, S" +
                "hippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipP" +
                "ostalCode, ShipCountry FROM Orders WHERE (OrderID = @OrderID)";
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"));
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = @"DELETE FROM Orders WHERE (OrderID = @Original_OrderID) AND (CustomerID = @Original_CustomerID OR @Original_CustomerID IS NULL AND CustomerID IS NULL) AND (EmployeeID = @Original_EmployeeID OR @Original_EmployeeID IS NULL AND EmployeeID IS NULL) AND (Freight = @Original_Freight OR @Original_Freight IS NULL AND Freight IS NULL) AND (OrderDate = @Original_OrderDate OR @Original_OrderDate IS NULL AND OrderDate IS NULL) AND (RequiredDate = @Original_RequiredDate OR @Original_RequiredDate IS NULL AND RequiredDate IS NULL) AND (ShipAddress = @Original_ShipAddress OR @Original_ShipAddress IS NULL AND ShipAddress IS NULL) AND (ShipCity = @Original_ShipCity OR @Original_ShipCity IS NULL AND ShipCity IS NULL) AND (ShipCountry = @Original_ShipCountry OR @Original_ShipCountry IS NULL AND ShipCountry IS NULL) AND (ShipName = @Original_ShipName OR @Original_ShipName IS NULL AND ShipName IS NULL) AND (ShipPostalCode = @Original_ShipPostalCode OR @Original_ShipPostalCode IS NULL AND ShipPostalCode IS NULL) AND (ShipRegion = @Original_ShipRegion OR @Original_ShipRegion IS NULL AND ShipRegion IS NULL) AND (ShipVia = @Original_ShipVia OR @Original_ShipVia IS NULL AND ShipVia IS NULL) AND (ShippedDate = @Original_ShippedDate OR @Original_ShippedDate IS NULL AND ShippedDate IS NULL)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Freight", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RequiredDate", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCity", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipCountry", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipName", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipRegion", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShipVia", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippedDate", System.Data.DataRowVersion.Original, null));
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=\"KOPI-2K\";packet size=4096;integrated security=SSPI;data source=\"K" +
                "OPI-2K\";persist security info=False;initial catalog=Northwind";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
                                                                                                      new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                                                                                                                                                                                                                new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "Orders.NumOrders"));
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void button1_Click(object sender, System.EventArgs e)
        {
            button1.Text="hello";
        }
	}
}
