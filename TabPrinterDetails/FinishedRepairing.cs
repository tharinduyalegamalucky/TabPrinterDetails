using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabPrinterDetails
{
    public partial class FinishedRepairing : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
        SqlCommand cm = new SqlCommand();


        public FinishedRepairing()
        {
            InitializeComponent();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FinishedRepairing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm = new SqlCommand("Select BrandID ,Brand from TP_Headers", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable table = new DataTable();
            da.Fill(table);
            DataRow defaultRow1 = table.NewRow();
            defaultRow1["Brand"] = "Select Brand";
            table.Rows.InsertAt(defaultRow1, 0);
            cmbBrand.DataSource = table;
            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.SelectedIndex = 0;
        }
    }
}
