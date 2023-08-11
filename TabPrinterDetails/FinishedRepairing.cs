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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want To This User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO TP_Repairing_Details(Srid,EmpNo,First_Name,Last_Name,Brand,EMEI_No,Position,Location,Asm,Distributor,Remarks) VALUES (@Srid,@EmpNo,@First_Name,@Last_Name,@Brand,@EMEI_No,@Position,@Location,@Asm,@Distributor,@Remarks)", con);


                    cm.Parameters.AddWithValue("@Brand", cmbBrand.Text);
                    cm.Parameters.AddWithValue("@Date", dateTimePicker1);
                    cm.Parameters.AddWithValue("@Result", txtResult.Text);
                    cm.Parameters.AddWithValue("@Remarks", txtRemark.Text);

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
