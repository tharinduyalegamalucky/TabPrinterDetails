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
    public partial class TabDetailsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public TabDetailsForm()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cm = new SqlCommand("SELECT * FROM PrinterTabDetails", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read()) { 
            }
        }
    }
}
