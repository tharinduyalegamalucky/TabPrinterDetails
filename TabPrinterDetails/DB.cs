using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace TabPrinterDetails
{
    public class DB
    {
        public static SqlConnection con;
        public static SqlCommand cm;


        public static SqlConnection getDBConn()
        {
            try
            {
                String strConnString = "Data Source = SD1\\SQLEXPRESS; Initial Catalog = PrinterTab; User ID = sa; Password=123";


                if (con == null)
                {
                    con = new SqlConnection();
                    con.ConnectionString = strConnString;


                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    con.Open();

                }

                return con;
           
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }
    }
}
