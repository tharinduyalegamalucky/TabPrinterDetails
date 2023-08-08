using Microsoft.Data.SqlClient;
using System.Data;

namespace TabPrinterDetails
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
        SqlCommand cm = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure You Want To This User?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO PrinterTabDetails(RepID,FirstName,LastName,EmpNo,Position,DistributorName,Location,IMINo,ASMName,Brand,Category,Remark1) VALUES (@RepID,@FirstName,@LastName,@EmpNo,@Position,@DistributorName,@Location,@IMINo,@ASMName,@Brand,@Category,@Remark1)", con);

                    //                   cm.Parameters.AddWithValue("@ID", IDTxt.Text);
                    cm.Parameters.AddWithValue("@RepID", repIDTxt.Text);
                    cm.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
                    cm.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
                    cm.Parameters.AddWithValue("@EmpNo", empTxt.Text);
                    cm.Parameters.AddWithValue("@Position", positionCombo.Text);
                    cm.Parameters.AddWithValue("@DistributorName", distributorCombo.Text);
                    cm.Parameters.AddWithValue("@Location", locationCombo.Text);
                    cm.Parameters.AddWithValue("@IMINo", serielCombo.Text);
                    cm.Parameters.AddWithValue("@ASMName", ASMCombo.Text);
                    cm.Parameters.AddWithValue("@Brand", brandCombo.Text);
                    cm.Parameters.AddWithValue("@Category", categoriesCombo.Text);
                    cm.Parameters.AddWithValue("@Remark1", remarkTxt.Text);
                    //cm.Parameters.AddWithValue("@Date", date);
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

        private void Form1_Load(object sender, EventArgs e)
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
            positionCombo.DataSource = table;
            positionCombo.DisplayMember = "Position";
            positionCombo.ValueMember = "PositionID";
            positionCombo.SelectedIndex = 0;


            distributorCombo.Visible = false;
            label1.Visible = false;





            SqlConnection con1 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm1 = new SqlCommand("Select BrandID ,Brand from TP_Headers", con1);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cm1;
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            DataRow defaultRow1 = table1.NewRow();
            defaultRow1["Brand"] = "Select Brand";
            table1.Rows.InsertAt(defaultRow1, 0);
            brandCombo.DataSource = table1;
            brandCombo.DisplayMember = "Brand";
            brandCombo.ValueMember = "BrandID";
            brandCombo.SelectedIndex = 0;
            brandCombo.SelectedIndex = 0;


            //brandCombo.Items.Add("Other");
            //brandCombo.Items.Add("Lenovo M8");
            //brandCombo.Items.Add("W40 Printer");
            //brandCombo.Items.Add("Svamsung A");

            categoriesCombo.Items.Add("Brand New");
            categoriesCombo.Items.Add("Used");

            //positionCombo.Items.Add("Other");
            //positionCombo.Items.Add("MD");
            //positionCombo.Items.Add("GM");
            //positionCombo.Items.Add("ASM");
            //positionCombo.Items.Add("UM");
            //positionCombo.Items.Add("HRM");
            //positionCombo.Items.Add("ITM");
            //positionCombo.Items.Add("Direct");
            //positionCombo.Items.Add("Distributor");
            //positionCombo.Items.Add("Staff");

            locationCombo.Items.Add("Centrel");
            locationCombo.Items.Add("Down South");
            locationCombo.Items.Add("Kaduwela");
            locationCombo.Items.Add("Head Office");

            distributorCombo.Items.Add("A");
            distributorCombo.Items.Add("B");
            distributorCombo.Items.Add("C");
            distributorCombo.Items.Add("D");

            ASMCombo.Items.Add("A");
            ASMCombo.Items.Add("B");
            ASMCombo.Items.Add("C");
            ASMCombo.Items.Add("D");


            serielCombo.Items.Add("A");
            serielCombo.Items.Add("B");
            serielCombo.Items.Add("C");
            serielCombo.Items.Add("D");
        }

        private void categoriesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        public void Clear()
        {
            IDTxt.Clear();
            repIDTxt.Clear();
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            empTxt.Clear();
            positionCombo.SelectedIndex = 0;
            distributorCombo.SelectedIndex = -1;
            locationCombo.SelectedIndex = -1;
            serielCombo.SelectedIndex = -1;
            ASMCombo.SelectedIndex = -1;
            brandCombo.SelectedIndex = -1;
            categoriesCombo.SelectedIndex = -1;
            remarkTxt.Clear();
            date.ResetText();

            //positionCombo.Items.Clear();
            //distributorCombo.Items.Clear();
            //locationCombo.Items.Clear();
            //serielCombo.Items.Clear();
            //date.ResetText();
            //ASMCombo.Items.Clear();
            //brandCombo.Items.Clear();
            //categoriesCombo.Items.Clear();

        }

        private void positionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = positionCombo.SelectedItem as DataRowView;

            if (selectedRow != null && selectedRow["PositionID"].ToString() == "8")
            {
                distributorCombo.Visible = true;
                label1.Visible = true;

                SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
                SqlCommand cm = new SqlCommand("Select DistName from Tbl_DistDetails ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cm;
                DataTable table = new DataTable();
                da.Fill(table);
                DataRow defaultRow = table.NewRow();
                defaultRow["DistName"] = "Select Distributor";
                table.Rows.InsertAt(defaultRow, 0);
                distributorCombo.DataSource = table;
                distributorCombo.DisplayMember = "DistName";
                distributorCombo.SelectedIndex = 0;


            }
            else
            {
                distributorCombo.Visible = false;
                label1.Visible = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



    }
}