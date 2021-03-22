using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HCI_Educator
{
    class Signup
    {
        SqlCommand cmd;

        string userName, usergender, userPassword, userEmail,userCountry, userMobileNumber, cipher;
        int key;

        public Signup(string uName, string ugender, string uPassword, string uEmail,string uCountry, string uMobileNo, int key, string cipher)
        {
            this.userName = uName;
            this.usergender = ugender;
            this.userPassword = uPassword;
            this.userEmail = uEmail;
            this.userCountry = uCountry;
            this.userMobileNumber = uMobileNo;
            this.key = key;
            this.cipher = cipher;
        }

        public string CreateUser()
        {
            string message = "";
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                cmd = new SqlCommand("INSERT INTO tblUser (userName, userGender, userPassword, userEmail, userCountry, userMobileNumber) VALUES ('" + userName + "','" + usergender + "','" + userPassword + "','" + userEmail + "','" + userCountry + "','" + userMobileNumber + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();

                if (key != 0 && cipher != "")
                {
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO tblCipher(userSecretKey,userEncryptedCode,userID) VALUES (" + key + ",'" + cipher + "',(SELECT TOP 1 (userID) from tblUser ORDER BY userID DESC))", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    message += "Two Step verification Done.\n ";
                }
                else
                {
                    message += "Without Two step verification Process\n";
                }

            }
            message += "User Signup Successfully.";
            return message;
        }

        public bool checkUser(string username)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                cmd = new SqlCommand("SELECT * FROM tblUser WHERE userName = '" + username + "'", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    return true;
                }
                return false;
            }
        }



    }
}
