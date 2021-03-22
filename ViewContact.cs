using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Educator
{
    public partial class ViewContact : MetroFramework.Forms.MetroForm
    {
        public ViewContact()
        {
            InitializeComponent();
        }

        private void ViewContact_Load(object sender, EventArgs e)
        {
            ViewPerson viewPerson = new ViewPerson();
            gridviewContacts.DataSource = viewPerson.showPerson().Tables[0];
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.Show();
        }

        private void GridviewContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ESDContacts esdContacts = new ESDContacts();
            esdContacts.lblPersonID.Text = this.gridviewContacts.CurrentRow.Cells[0].Value.ToString();
            esdContacts.txtFname.Text = this.gridviewContacts.CurrentRow.Cells[1].Value.ToString();
            esdContacts.txtLname.Text = this.gridviewContacts.CurrentRow.Cells[2].Value.ToString();
            esdContacts.txtDispName.Text = this.gridviewContacts.CurrentRow.Cells[3].Value.ToString();
            esdContacts.txtTitle.Text = this.gridviewContacts.CurrentRow.Cells[5].Value.ToString();
            esdContacts.txtLocation.Text = this.gridviewContacts.CurrentRow.Cells[6].Value.ToString();
            esdContacts.txtWork.Text = this.gridviewContacts.CurrentRow.Cells[7].Value.ToString();
            esdContacts.txtResAddress.Text = this.gridviewContacts.CurrentRow.Cells[8].Value.ToString();
            esdContacts.txtOtherAddress.Text = this.gridviewContacts.CurrentRow.Cells[9].Value.ToString();
            esdContacts.txtMobileNumber.Text = this.gridviewContacts.CurrentRow.Cells[10].Value.ToString();
            esdContacts.txtHomeNumber.Text = this.gridviewContacts.CurrentRow.Cells[11].Value.ToString();
            esdContacts.txtOfficeNumber.Text = this.gridviewContacts.CurrentRow.Cells[12].Value.ToString();
            esdContacts.txtOtherNumber.Text = this.gridviewContacts.CurrentRow.Cells[13].Value.ToString();
            esdContacts.txtEmailAddress.Text = this.gridviewContacts.CurrentRow.Cells[14].Value.ToString();
            esdContacts.txtOtherEmailAddress.Text = this.gridviewContacts.CurrentRow.Cells[15].Value.ToString();
            esdContacts.txtNote.Text = this.gridviewContacts.CurrentRow.Cells[16].Value.ToString();
            this.Hide();
            esdContacts.Show();
        }

        void Display()
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            DataTable dt = new DataTable();
            if (txtSeacrhByDispName.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblPhoneDairy WHERE Display_Name LIKE '" + txtSeacrhByDispName.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (txtSearchByMobile.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblPhoneDairy WHERE Mobile_Number LIKE '" + txtSearchByMobile.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (txtSearchByLocation.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblPhoneDairy WHERE Location LIKE '" + txtSearchByLocation.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (txtSeacrhByEmail.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblPhoneDairy WHERE Email_Address LIKE '" + txtSeacrhByEmail.Text + "%'", con);
                sda.Fill(dt);
            }
            gridviewContacts.DataSource = dt;
        }

        private void TxtSeacrhByDispName_OnTextChange(object sender, EventArgs e)
        {
            txtSearchByMobile.text = "";
            txtSearchByLocation.text = "";
            txtSeacrhByEmail.text = "";
            Display();
        }

        private void TxtSearchByMobile_OnTextChange(object sender, EventArgs e)
        {
            txtSeacrhByDispName.text = "";
            txtSearchByLocation.text = "";
            txtSeacrhByEmail.text = "";
            Display();
        }

        private void TxtSearchByLocation_OnTextChange(object sender, EventArgs e)
        {
            txtSearchByMobile.text = "";
            txtSeacrhByDispName.text = "";
            txtSeacrhByEmail.text = "";
            Display();
        }

        private void TxtSeacrhByEmail_OnTextChange(object sender, EventArgs e)
        {
            txtSearchByMobile.text = "";
            txtSearchByLocation.text = "";
            txtSeacrhByDispName.text = "";
            Display();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ViewPerson viewPerson = new ViewPerson();
            gridviewContacts.DataSource = viewPerson.showPerson().Tables[0];
        }

        private void RbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblPhoneDairy where Gender = 'Male'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridviewContacts.DataSource = dt;
        }

        private void RbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblPhoneDairy where Gender = 'Female'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridviewContacts.DataSource = dt;
        }
    }
}
