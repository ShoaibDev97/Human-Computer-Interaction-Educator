using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HCI_Educator
{
    class CountryCode
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();

        public DataSet showCountry()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                string query = "select * from tblCountry";
                sda = new SqlDataAdapter(query, con);
                sda.Fill(ds);
            }
            return ds;
        }
    }
}
