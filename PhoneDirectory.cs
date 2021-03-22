using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Educator
{
    public partial class PhoneDirectory : MetroFramework.Forms.MetroForm
    {
        public PhoneDirectory()
        {
            InitializeComponent();
        }

        private void TxtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtDispName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtWork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtMobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtHomeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtOfficeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtOtherNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtEmailAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtFname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                lblFname.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFname.Text = "";
            }
            else
            {
                lblFname.Visible = true;
            }
        }

        private void TxtLname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLname.Text))
            {
                lblLname.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLname.Text = "";
            }
            else
            {
                lblLname.Visible = true;
            }
        }

        private void TxtDispName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDispName.Text))
            {
                lblDisName.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtDispName.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDispName.Text = "";
            }
            else
            {
                lblDisName.Visible = true;
            }
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblTitle.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Text = "";
            }
            else
            {
                lblTitle.Visible = true;
            }
        }

        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                lblLocation.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Text = "";
            }
            else
            {
                lblLocation.Visible = true;
            }
        }

        private void TxtWork_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWork.Text))
            {
                lblWork.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtWork.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWork.Text = "";
            }
            else
            {
                lblWork.Visible = true;
            }
        }

        private void TxtResAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResAddress.Text))
            {
                lblResAddress.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtResAddress.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResAddress.Text = "";
            }
            else
            {
                lblResAddress.Visible = true;
            }
        }

        private void TxtOtherAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtherAddress.Text))
            {
                lblOtherAddress.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtOtherAddress.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOtherAddress.Text = "";
            }
            else
            {
                lblOtherAddress.Visible = true;
            }
        }

        private void TxtMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                lblMobileNumber.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobileNumber.Text = "";
            }
            else
            {
                lblMobileNumber.Visible = true;
            }
        }

        private void TxtHomeNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHomeNumber.Text))
            {
                lblHomeNUmber.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtHomeNumber.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHomeNumber.Text = "";
            }
            else
            {
                lblHomeNUmber.Visible = true;
            }
        }

        private void TxtOfficeNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOfficeNumber.Text))
            {
                lblOfficeumber.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtOfficeNumber.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOfficeNumber.Text = "";
            }
            else
            {
                lblOfficeumber.Visible = true;
            }
        }

        private void TxtOtherNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtherNumber.Text))
            {
                lblOtherNumber.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtOtherNumber.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOtherNumber.Text = "";
            }
            else
            {
                lblOtherNumber.Visible = true;
            }
        }

        private void TxtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                lblEmailAddress.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmailAddress.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailAddress.Text = "";
            }
            else
            {
                lblEmailAddress.Visible = true;
            }
            
        }

        private void TxtOtherEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOtherEmailAddress.Text))
            {
                lblOtherEmailAddress.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtOtherEmailAddress.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOtherEmailAddress.Text = "";
            }
            else
            {
                lblOtherEmailAddress.Visible = true;
            }
        }

        private void TxtNote_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNote.Text))
            {
                lblNote.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWork.Text = "";
            }
            else
            {
                txtNote.Visible = true;
            }
        }

        private void TxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void TxtHomeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void TxtOfficeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void TxtOtherNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void BtnSaveContact_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" && txtLname.Text == "" && txtDispName.Text == "" && txtTitle.Text == "" &&
               txtLocation.Text == "" && txtWork.Text == "" && txtResAddress.Text == "" && txtOtherAddress.Text == "" &&
               txtMobileNumber.Text == "" && txtHomeNumber.Text == "" && txtOfficeNumber.Text == "" && txtOtherNumber.Text == "" &&
               txtEmailAddress.Text == "" && txtOtherEmailAddress.Text == "" && txtNote.Text == "")
            {
                MessageBox.Show("Please! Enter all entities.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Gender = "";
                if ((rbtnMale.Checked) || (rbtnMale.Checked))
                {
                    if (rbtnMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }

                    CreateContact createContact = new CreateContact(txtFname.Text, txtLname.Text, txtDispName.Text, Gender, txtTitle.Text, txtLocation.Text, txtWork.Text, txtResAddress.Text, txtOtherAddress.Text, txtMobileNumber.Text, txtHomeNumber.Text, txtOfficeNumber.Text, txtOtherNumber.Text, txtEmailAddress.Text, txtOtherEmailAddress.Text, txtNote.Text);
                    createContact.CreatePerson();
                    animator.Show(panelContactCreated);
                }
                else
                {
                    MessageBox.Show("Please select Gender....", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnNewContact_Click(object sender, EventArgs e)
        {
            panelContactCreated.Visible = false;
            txtFname.Text = "";
            txtLname.Text = "";
            txtDispName.Text = "";
            rbtnFemale.Checked = false;
            rbtnMale.Checked = false;
            txtTitle.Text = "";
            txtLocation.Text = "";
            txtWork.Text = "";
            txtResAddress.Text = "";
            txtOtherAddress.Text = "";
            txtMobileNumber.Text = "";
            txtHomeNumber.Text = "";
            txtOfficeNumber.Text = "";
            txtOtherAddress.Text = "";
            txtEmailAddress.Text = "";
            txtOtherEmailAddress.Text = "";
            txtNote.Text = "";
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

        private void PhoneDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void LblSaveContact_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" && txtLname.Text == "" && txtDispName.Text == "" && txtTitle.Text == "" &&
               txtLocation.Text == "" && txtWork.Text == "" && txtResAddress.Text == "" && txtOtherAddress.Text == "" &&
               txtMobileNumber.Text == "" && txtHomeNumber.Text == "" && txtOfficeNumber.Text == "" && txtOtherNumber.Text == "" &&
               txtEmailAddress.Text == "" && txtOtherEmailAddress.Text == "" && txtNote.Text == "")
            {
                MessageBox.Show("Please! Enter all entities.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Gender = "";
                if ((rbtnMale.Checked) || (rbtnMale.Checked))
                {
                    if (rbtnMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }

                    CreateContact createContact = new CreateContact(txtFname.Text, txtLname.Text, txtDispName.Text, Gender, txtTitle.Text, txtLocation.Text, txtWork.Text, txtResAddress.Text, txtOtherAddress.Text, txtMobileNumber.Text, txtHomeNumber.Text, txtOfficeNumber.Text, txtOtherNumber.Text, txtEmailAddress.Text, txtOtherEmailAddress.Text, txtNote.Text);
                    createContact.CreatePerson();
                    animator.Show(panelContactCreated);
                }
                else
                {
                    MessageBox.Show("Please select Gender....", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnViewContacts_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewContact viewContact = new ViewContact();
            viewContact.Show();
        }

        private void LblViewContacts_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewContact viewContact = new ViewContact();
            viewContact.Show();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.Show();
        }
    }
}
