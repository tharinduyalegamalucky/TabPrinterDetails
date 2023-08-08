using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabPrinterDetails
{
    class DB
    {
        public DB() {
            SqlConnection con = new SqlConnection(@"Data Source = SD1\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123");
            SqlCommand cm = new SqlCommand("Select PositionID,Position from Tbl_Position ", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cm;
        }
    }
}
