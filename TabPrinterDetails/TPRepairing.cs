using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TabPrinterDetails
{
    public partial class TPRepairing : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
        SqlCommand cm = new SqlCommand();

        public TPRepairing()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TPRepairing_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm = new SqlCommand("Select PositionID,Position from Tbl_Position ", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
            DataTable table = new DataTable();
            da.Fill(table);
            DataRow defaultRow = table.NewRow();
            defaultRow["PositionID"] = 0;
            defaultRow["Position"] = "Select Position";
            table.Rows.InsertAt(defaultRow, 0);
            cmbPosition.DataSource = table;
            cmbPosition.DisplayMember = "Position";
            cmbPosition.ValueMember = "PositionID";
            cmbPosition.SelectedIndex = 0;


            cmbDistributor.Visible = false;
            label5.Visible = false;





            SqlConnection con1 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm1 = new SqlCommand("Select BrandID ,Brand from TP_Headers", con1);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cm1;
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            DataRow defaultRow1 = table1.NewRow();
            defaultRow1["Brand"] = "Select Brand";
            table1.Rows.InsertAt(defaultRow1, 0);
            cmbBrand.DataSource = table1;
            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.SelectedIndex = 0;







            SqlConnection con3 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm3 = new SqlCommand("SELECT Name, ASM_ID FROM ASM", con3);
            SqlDataAdapter da3 = new SqlDataAdapter();
            da3.SelectCommand = cm3;
            DataTable table3 = new DataTable();
            da3.Fill(table3);
            DataRow defaultRow3 = table3.NewRow();
            defaultRow3["Name"] = "Select ";
            table3.Rows.InsertAt(defaultRow3, 0);
            cmbAsm.DataSource = table3;
            cmbAsm.DisplayMember = "Name";
            cmbAsm.ValueMember = "ASM_ID";
            cmbAsm.SelectedIndex = 0;













            SqlConnection con4 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm4 = new SqlCommand("SELECT Location_ID, Location_Name FROM Location", con4);
            SqlDataAdapter da4 = new SqlDataAdapter();
            da4.SelectCommand = cm4;
            DataTable table4 = new DataTable();
            da4.Fill(table4);
            DataRow defaultRow4 = table4.NewRow();
            defaultRow4["Location_Name"] = "Select Location";
            table4.Rows.InsertAt(defaultRow4, 0);
            cmbLocation.DataSource = table4;
            cmbLocation.DisplayMember = "Location_Name";
            cmbLocation.ValueMember = "Location_ID";
            cmbLocation.SelectedIndex = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want To This User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO TP_Repairing_Details(Srid,EmpNo,First_Name,Last_Name,Brand,EMEI_No,Position,Location,Asm,Distributor,Remarks) VALUES (@Srid,@EmpNo,@First_Name,@Last_Name,@Brand,@EMEI_No,@Position,@Location,@Asm,@Distributor,@Remarks)", con);


                    cm.Parameters.AddWithValue("@Srid", txtSrid.Text);
                    cm.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
                    cm.Parameters.AddWithValue("@First_Name", txtFName.Text);
                    cm.Parameters.AddWithValue("@Last_Name", txtLName.Text);
                    cm.Parameters.AddWithValue("@Brand", cmbBrand.Text);
                    cm.Parameters.AddWithValue("@EMEI_No", txtSeriel.Text);
                    cm.Parameters.AddWithValue("@Position", cmbPosition.Text);
                    cm.Parameters.AddWithValue("@Location", cmbLocation.Text);
                    //cm.Parameters.AddWithValue("@Date", dateTimePicker1);
                    cm.Parameters.AddWithValue("@Asm", cmbAsm.Text);
                    cm.Parameters.AddWithValue("@Distributor", cmbDistributor.Text);
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

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbPosition.SelectedItem as DataRowView;

            if (selectedRow != null && selectedRow["PositionID"].ToString() == "8")
            {
                cmbDistributor.Visible = true;
                label5.Visible = true;

                SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
                SqlCommand cm = new SqlCommand("Select DistName from Tbl_DistDetails ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cm;
                DataTable table = new DataTable();
                da.Fill(table);
                DataRow defaultRow = table.NewRow();
                defaultRow["DistName"] = "Select Distributor";
                table.Rows.InsertAt(defaultRow, 0);
                cmbDistributor.DataSource = table;
                cmbDistributor.DisplayMember = "DistName";
                cmbDistributor.SelectedIndex = 0;


            }
            else
            {
                cmbDistributor.Visible = false;
                label5.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        public void Clear()
        {
            //IDTxt.Clear();
            txtSrid.Clear();
            txtEmpNo.Clear();
            txtFName.Clear();
            txtLName.Clear();
            cmbBrand.SelectedIndex = 0;
            txtSeriel.Clear();
            cmbPosition.SelectedIndex = -1;
            cmbLocation.SelectedIndex = -1;
            cmbAsm.SelectedIndex = -1;
            cmbDistributor.SelectedIndex = -1;
            txtRemark.Clear();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}


