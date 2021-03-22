using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HCI_Educator
{
    class CreateContact
    {
        SqlCommand cmd;

        string Fname, Lname, DispName, Gender, Title,Location, Job, ResAddress, OtherAdd, MobileNum, HomeNum, OfficeNum, OtherNum, EmailAdd, OtherEmailAdd, Note;
        
        public CreateContact(string fn, string ln, string dn, string g, string t, string lo, string j, string ra, string oa, string mn, string hn, string ofn, string on, string ea, string oe, string n)
        {
            this.Fname = fn;
            this.Lname = ln;
            this.DispName = dn;
            this.Gender = g;
            this.Title = t;
            this.Location = lo;
            this.Job = j;
            this.ResAddress = ra;
            this.OtherAdd = oa;
            this.MobileNum = mn;
            this.HomeNum = hn;
            this.OfficeNum = ofn;
            this.OtherNum = on;
            this.EmailAdd = ea;
            this.OtherEmailAdd = oe;
            this.Note = n;
        }

        public string CreatePerson()
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                cmd = new SqlCommand("INSERT INTO tblPhoneDairy (First_Name, Last_Name, Display_Name, Gender, Title, Location, Job, Residential_Address, Other_Address, Mobile_Number, Home_Number, Office_Number, Other_Number, Email_Address, Other_Email_Address, Note) " +
                "VALUES ('" + Fname + "', '" + Lname + "', '" + DispName + "', '" + Gender + "', '" + Title + "', '" + Location + "', '" + Job + "', '" + ResAddress + "', '" + OtherAdd + "','" + MobileNum + "','" + HomeNum + "','" + OfficeNum + "','" + OtherNum + "','" + EmailAdd + "','" + OtherEmailAdd + "','" + Note + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            return "Contact Created Successfully";
        }

    }
}
