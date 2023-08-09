using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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







            SqlConnection con3 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm3 = new SqlCommand("SELECT Name, ASM_ID FROM ASM", con3);
            SqlDataAdapter da3 = new SqlDataAdapter();
            da3.SelectCommand = cm3;
            DataTable table3 = new DataTable();
            da3.Fill(table3);
            DataRow defaultRow3 = table3.NewRow();
            defaultRow3["Name"] = "Select ";
            table3.Rows.InsertAt(defaultRow3, 0);
            ASMCombo.DataSource = table3;
            ASMCombo.DisplayMember = "Name";
            ASMCombo.ValueMember = "ASM_ID";
            ASMCombo.SelectedIndex = 0;




            SqlConnection con4 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm4 = new SqlCommand("SELECT Location_ID, Location_Name FROM Location", con4);
            SqlDataAdapter da4 = new SqlDataAdapter();
            da4.SelectCommand = cm4;
            DataTable table4 = new DataTable();
            da4.Fill(table4);
            DataRow defaultRow4 = table4.NewRow();
            defaultRow4["Location_Name"] = "Select Location";
            table4.Rows.InsertAt(defaultRow4, 0);
            locationCombo.DataSource = table4;
            locationCombo.DisplayMember = "Location_Name";
            locationCombo.ValueMember = "Location_ID";
            locationCombo.SelectedIndex = 0;






            SqlConnection con5 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm5 = new SqlCommand("SELECT ID, Categories FROM Categories", con5);
            SqlDataAdapter da5 = new SqlDataAdapter();
            da5.SelectCommand = cm5;
            DataTable table5 = new DataTable();
            da5.Fill(table5);
            DataRow defaultRow5 = table5.NewRow();
            defaultRow5["Categories"] = "Select Categories";
            table5.Rows.InsertAt(defaultRow5, 0);
            categoriesCombo.DataSource = table5;
            categoriesCombo.DisplayMember = "Categories";
            categoriesCombo.ValueMember = "ID";
            categoriesCombo.SelectedIndex = 0;





            //categoriesCombo.Items.Add("Brand New");
            //categoriesCombo.Items.Add("Used");





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
            SqlConnection con2 = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm2 = new SqlCommand("SELECT TD.IMIE_NO1 FROM dbo.TP_Details TD INNER JOIN dbo.TP_Headers TH ON TH.BrandID = TD.TP_ID WHERE TH.BrandID = '" + brandCombo.SelectedIndex + "' AND TD.Active=0", con2);
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cm2;
            DataTable table2 = new DataTable();
            da2.Fill(table2);

            // Create a default row using the same data type as IMIE_NO1 column
            DataRow defaultRow2 = table2.NewRow();
            defaultRow2["IMIE_NO1"] = 0;
            table2.Rows.InsertAt(defaultRow2, 0);

            serielCombo.DataSource = table2;
            serielCombo.DisplayMember = "IMIE_NO1";
            serielCombo.ValueMember = "IMIE_NO1";
            serielCombo.SelectedIndex = 0;

        }

        private void serielCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}