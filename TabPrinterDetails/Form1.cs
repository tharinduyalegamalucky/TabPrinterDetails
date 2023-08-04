using Microsoft.Data.SqlClient;
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
                    cm = new SqlCommand("INSERT INTO PrinterTabDetails(ID,RepID,FirstName,LastName,EmpNo,Position,DistributorName,Location,IMINo,ASMName,Brand,Category,Remark1) VALUES(@ID,@RepID,@FirstName,@LastName,@EmpNo,@Position,@DistributorName,@Location,@IMINo,@ASMName,@Brand,@Category,@Remark1)", con);
                    cm.Parameters.AddWithValue("@ID", IDTxt.Text);
                    cm.Parameters.AddWithValue("@RepID", repIDTxt.Text);
                    cm.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
                    cm.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
                    cm.Parameters.AddWithValue("@EmpNo", empTxt.Text);
                    cm.Parameters.AddWithValue("@Position", positionCombo.Text);
                    cm.Parameters.AddWithValue("@DistributorName", distributorCombo.Text);
                    cm.Parameters.AddWithValue("@Location", locationCombo.Text);
                    cm.Parameters.AddWithValue("@IMINo", serielCombo.Text);
                    //                   cm.Parameters.AddWithValue("@Date", date);
                    cm.Parameters.AddWithValue("@ASMName", ASMCombo.Text);
                    cm.Parameters.AddWithValue("@Brand", brandCombo.Text);
                    cm.Parameters.AddWithValue("@Category", categoriesCombo.Text);
                    cm.Parameters.AddWithValue("@Remark1", remarkTxt.Text);
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
            brandCombo.Items.Add("Other");
            brandCombo.Items.Add("Lenovo M8");
            brandCombo.Items.Add("W40 Printer");
            brandCombo.Items.Add("Svamsung A");

            categoriesCombo.Items.Add("Brand New");
            categoriesCombo.Items.Add("Used");

            positionCombo.Items.Add("Other");
            positionCombo.Items.Add("MD");
            positionCombo.Items.Add("GM");
            positionCombo.Items.Add("ASM");
            positionCombo.Items.Add("UM");
            positionCombo.Items.Add("HRM");
            positionCombo.Items.Add("ITM");
            positionCombo.Items.Add("Direct");
            positionCombo.Items.Add("Distributor");
            positionCombo.Items.Add("Staff");

            locationCombo.Items.Add("Centrel");
            locationCombo.Items.Add("Down South");
            locationCombo.Items.Add("Kaduwela");
            locationCombo.Items.Add("Head Office");

            distributorCombo.Items.Add("");
        }

        private void categoriesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            IDTxt.Clear();
            repIDTxt.Clear();
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            empTxt.Clear();
            positionCombo.Items.Clear();
            distributorCombo.Items.Clear();
            locationCombo.Items.Clear();
            serielCombo.Items.Clear();
            //           date.ResetText();
            ASMCombo.Items.Clear();
            brandCombo.Items.Clear();
            categoriesCombo.Items.Clear();
            remarkTxt.Clear();

        }
    }
}