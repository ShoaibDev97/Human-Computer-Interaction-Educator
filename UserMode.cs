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
    public partial class UserMode : MetroFramework.Forms.MetroForm
    {
        public UserMode()
        {
            InitializeComponent();
        }

        private void UserMode_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdminInfo_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void BtnAdminInfo_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void BtnUserInfo_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void BtnUserInfo_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void UserMode_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            userSignin.Show();
        }
    }
}
