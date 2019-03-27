using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project06
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();

            DataSet productSet = new DataSet();
            DataTable productTable = productSet.Tables.Add("Product"); 
            productTable.Columns.Add("ProductId"); 
            productTable.Columns.Add("ProductName");
            productTable.Columns.Add("SalesPrice");

            DataRow row1 = productTable.NewRow(); 
            row1["ProductId"] = 301; 
            row1["ProductName"] = "Cep Telefonu";
            row1["SalesPrice"] = 1400;
            productTable.Rows.Add(row1); 

            DataRow row2 = productTable.NewRow();
            row2["ProductId"] = 302;
            row2["ProductName"] = "Masaüstü Bilgisayar";
            row2["SalesPrice"] = 3500;
            productTable.Rows.Add(row2);

            DataRow row3 = productTable.NewRow();
            row3["ProductId"] = 303;
            row3["ProductName"] = "Dizüstü Bilgisayar";
            row3["SalesPrice"] = 5350;
            productTable.Rows.Add(row3);

            productGridView.ReadOnly = true; 

            productGridView.DataSource = productSet; 
            productGridView.DataMember = "Product";
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {

        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
