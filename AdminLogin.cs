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
    public partial class AdminLogin : MetroFramework.Forms.MetroForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUserName.Visible = false;
            }
            else
            {
                lblUserName.Visible = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblPswd.Visible = false;
            }
            else
            {
                lblPswd.Visible = true;
            }
        }

        private void PicShowpaswd_Click(object sender, EventArgs e)
        {
            picShowpaswd.Visible = false;
            picHidepswd.Visible = true;
            txtPassword.PasswordChar = '\0';
        }

        private void PicHidepswd_Click(object sender, EventArgs e)
        {
            picShowpaswd.Visible = true;
            picHidepswd.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void LblBacktoUserMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMode um = new UserMode();
            um.Show();
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 8 && e.KeyChar <= 32))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Please Enter Alphabes Only", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void LblForgotPswd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForgotPassword adminForgotPassword = new AdminForgotPassword();
            adminForgotPassword.Show();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMode um = new UserMode();
            um.Show();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please! Enter UserName and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please! Enter UserName", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please! Enter Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = "admin";
                string password = "abc123";
                if (txtUsername.Text == name && txtPassword.Text == password)
                {
                    this.Hide();
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.Show();
                }
                else if (txtUsername.Text != name)
                {
                    MessageBox.Show("User Name incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtPassword.Text != password)
                {
                    MessageBox.Show("Password incorrect", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please! Enter User Name and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
