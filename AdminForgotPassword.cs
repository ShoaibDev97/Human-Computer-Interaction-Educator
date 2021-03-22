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
    public partial class AdminForgotPassword : MetroFramework.Forms.MetroForm
    {
        private int ticks = 10;

        string serviceNumber = "BSCS8461";

        public AdminForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnSendReq_Click(object sender, EventArgs e)
        {
            if (txtServiceNum.Text == serviceNumber)
            {
                timer1.Start();
                picWait.Visible = true;
                btnSendReq.Enabled = false;
                bunifuSeparator1.Visible = false;
                lblBacktoAdminLogin.Visible = false;
                picBack.Visible = false;
                txtServiceNum.Enabled = false;
                btnSendReq.Text = "Sending your Request";
                ticks = 10;
            }
            else
            {
                lblServiceNum.Visible = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTime.Text = ticks.ToString();
            if (ticks == 6)
            {
                picWait.Visible = false;
                btnSendReq.Text = "Wait a Second!";
            }
            else if (ticks == 5)
            {
                lblUsernamePassword.Visible = true;
                lblDisappeartxt.Visible = true;
                lblSecondtxt.Visible = true;
                lblTime.Visible = true;
                btnSendReq.Text = "Done!";
            }
            else if (ticks == 0)
            {
                timer1.Stop();
                picTimeOut.Visible = true;
                lblUsernamePassword.Visible = false;
                lblDisappeartxt.Visible = false;
                lblSecondtxt.Visible = false;
                lblTime.Visible = false;
                lblSendReq.Visible = true;
                lblReqTimedOut.Visible = true;
                btnSendReq.Enabled = true;
                bunifuSeparator1.Visible = true;
                lblBacktoAdminLogin.Visible = true;
                picBack.Visible = true;
                btnSendReq.Text = "Send Request";
                txtServiceNum.Enabled = true;
                txtServiceNum.Text = "";
            }
        }

        private void TxtServiceNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSendReq.Visible = false;
            lblReqTimedOut.Visible = false;
            lblServiceNum.Visible = false;
            picTimeOut.Visible = false;
        }

        private void LblBacktoAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        private void AdminForgotPassword_Load(object sender, EventArgs e)
        {
        }

        private void TxtServiceNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtServiceNum_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServiceNum.Text))
            {
                lblEnterServiceNum.Visible = false;
            }
            else
            {
                lblEnterServiceNum.Visible = true;
            }
        }
    }
}
