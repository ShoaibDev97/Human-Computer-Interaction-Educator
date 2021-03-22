using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HCI_Educator
{
    class Signin
    {
        SqlCommand cmd;
        SqlDataReader sdr;

        public bool AuthenticateUser(string name, string password)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE userName = '" + name + "' AND userPassword = '" + password + "'", con);
                con.Open();
                sdr = cmd.ExecuteReader();
                return sdr.Read();
            }
        }

        public bool checkCipher(string username)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                cmd = new SqlCommand("SELECT * FROM tblCipher WHERE userID = (SELECT userID from tblUser Where userName = '" + username + "')", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    con.Close();
                    return true;
                }
                return false;
            }
        }

        public string getCipher(string username)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                string cipher = "";
                cmd = new SqlCommand("SELECT userEncryptedCode FROM tblCipher WHERE userID = (SELECT userID from tblUser Where userName = '" + username + "')", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cipher = rd[0].ToString();
                }
                con.Close();

                return cipher;
            }
        }

    }
}
