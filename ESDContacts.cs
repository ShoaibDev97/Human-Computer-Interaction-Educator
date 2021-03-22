using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HCI_Educator
{
    public partial class ESDContacts : MetroFramework.Forms.MetroForm
    {
        public ESDContacts()
        {
            InitializeComponent();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            btnCross.Visible = true;
            animator.Show(btnEdit);
            animator.Show(btnUpdate);
            animator.Show(btnDelete);
            animator.Show(btnSave);
        }

        private void BtnCross_Click(object sender, EventArgs e)
        {
            btnCross.Visible = false;
            btnPlus.Visible = true;
            animator.Hide(btnSave);
            animator.Hide(btnDelete);
            animator.Hide(btnUpdate);
            animator.Hide(btnEdit);
        }

        private void ViewContacts_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtFname.Enabled = true;
            txtLname.Enabled = true;
            txtDispName.Enabled = true;
            txtTitle.Enabled = true;
            txtLocation.Enabled = true;
            txtWork.Enabled = true;
            txtResAddress.Enabled = true;
            txtOtherAddress.Enabled = true;
            txtMobileNumber.Enabled = true;
            txtHomeNumber.Enabled = true;
            txtOfficeNumber.Enabled = true;
            txtOtherNumber.Enabled = true;
            txtEmailAddress.Enabled = true;
            txtOtherEmailAddress.Enabled = true;
            txtNote.Enabled = true;
        }

        private void BtnEditPic_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg|*jpg";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                picPerson.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        SqlCommand cmd;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE tblPhoneDairy SET First_Name='" + txtFname.Text + "', Last_Name='" + txtLname.Text + "', Display_Name='" + txtDispName.Text + "', Title='" + txtTitle.Text + "', Location='" + txtLocation.Text + "', Job='" + txtWork.Text + "', Residential_Address='" + txtResAddress.Text + "', Other_Address='" + txtOtherAddress.Text + "', Mobile_Number='" + txtMobileNumber.Text + "', Home_Number='" + txtHomeNumber.Text + "', Office_Number='" + txtOfficeNumber.Text + "', Other_Number='" + txtOtherNumber.Text + "', Email_Address='" + txtEmailAddress.Text + "', Other_Email_Address='" + txtOtherEmailAddress.Text + "', Note='" + txtNote.Text + "' WHERE PersonID='" + lblPersonID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                animator1.Show(panelContactUpdate);
                lblPath.Visible = false;
                textSuccess.Text = "Contact Successfully Updated";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Program.connectionString))
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM tblPhoneDairy WHERE PersonID='" + lblPersonID.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                animator1.Show(panelContactUpdate);
                lblPath.Visible = false;
                textSuccess.Text = "Contact Successfully Deleted";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(panelDetails.Width, panelDetails.Height))
            {
                panelDetails.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"Contacts/" + lblContactDetails.Text + ".bmp");
                animator1.Show(panelContactUpdate);
                lblPath.Visible = true;
                textSuccess.Text = "Contact Successfully Saved";
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            //miss the panel :(
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            //miss the panel :(
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewContact viewContact = new ViewContact();
            viewContact.Show();
        }

        private void Returnbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.Show();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.Show();
        }
    }
}
