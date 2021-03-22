using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HCI_Educator
{
    class Verifcation
    {
        public string getPassword(string num)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                string password = "";
                SqlCommand cmd = new SqlCommand("Select userPassword from tblUser Where userMobileNumber = '" +num+"'",con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    password = rd[0].ToString();
                }
                con.Close();
                return password;
            }
        }

        public string getPasswordfromEmail(string email)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                string password = "";
                SqlCommand cmd = new SqlCommand("Select userPassword from tblUser Where UserEmail = '" + email + "'",con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    password = rd[0].ToString();
                }
                con.Close();
                return password;
            }
        }
    }
}
