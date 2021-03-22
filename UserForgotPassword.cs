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
    public partial class UserForgotPassword : MetroFramework.Forms.MetroForm
    {
        private int ticks1 = 60;
        private int ticks2 = 3;

        public static bool fromThis = false;
        public static string number = "";
        public static string email = "";

        public UserForgotPassword(string receivinguserName)
        {
            InitializeComponent();
            btnShownUserName.ButtonText = receivinguserName;
            btnShowUserName.ButtonText = receivinguserName;
        }

        private void UserForgotPassword_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks1--;
            lblTimer1.Text = ticks1.ToString();
            if (ticks1 == 0)
            {
                animator1.Show(panelSessionTimeout);
                panelMobile.Visible = false;
                panelEmail.Visible = false;
                panelNotFound.Visible = false;
                bunifuSeparator1.Visible = false;
                picBack.Visible = false;
                lblBacktoSigninForm.Visible = false;
                timer1.Stop();
            }
        }

        private void LblTryAnotherWayMobile_Click(object sender, EventArgs e)
        {
            ticks1 = 60;
            panelMobile.Visible = false;
            animator1.Show(panelEmail);
            txtEmail.Text = "";
            lblInvalidEmail.Visible = false;
        }

        private void LblTryAnotherWayEmail_Click(object sender, EventArgs e)
        {
            ticks1 = 60;
            panelEmail.Visible = false;
            animator1.Show(panelNotFound);
            txtMobileNumber.Text = "";
            lblInvalidNumber.Visible = false;
        }

        private void BtnStartOver_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            //userSignin.Show();
            animator1.Show(userSignin);
        }

        private void LblBacktoSigninForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            animator1.Show(userSignin);
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            animator1.Show(userSignin);
        }

        private void TxtMobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Visible = false;
            }
            else
            {
                lblEmail.Visible = true;
            }
        }

        private void TxtMobileNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNumber.Text))
            {
                lblNumber.Visible = false;
            }
            else
            {
                lblNumber.Visible = true;
            }
        }

        private void TxtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInvalidNumber.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
        }

        private void LblEmailAddress_Click(object sender, EventArgs e)
        {
            panelMobile.Visible = false;
            animator1.Show(panelEmail);
            txtEmail.Text = "";
            lblInvalidEmail.Visible = false;
            ticks1 = 60;
        }

        private void LblMobileNumber_Click(object sender, EventArgs e)
        {
            animator1.Show(panelMobile);
            panelEmail.Visible = false;
            txtMobileNumber.Text = "";
            lblInvalidNumber.Visible = false;
            ticks1 = 60;
        }

        private void BtnVerifyNumber_Click(object sender, EventArgs e)
        {
            Verifcation vf = new Verifcation();
            string pass = vf.getPassword(txtMobileNumber.Text);
            ticks1 = 60;
            if (txtMobileNumber.Text == "")
            {
                MessageBox.Show("Please! Enter your Mobile Number...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pass != "")
            {
                fromThis = true;
                number = txtMobileNumber.Text;
                timer2.Start();
                ticks2 = 3;
                miniLoadMsg.Visible = true;
            }
            else
            {
                fromThis = false;
                number = "";
                lblInvalidNumber.Visible = true;
            }
        }

        private void BtnVerifyEmail_Click(object sender, EventArgs e)
        {
            Verifcation vf = new Verifcation();
            string pass = vf.getPasswordfromEmail(txtEmail.Text);
            ticks1 = 60;
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please! Enter your Email Address...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (pass != "")
            {
                fromThis = true;
                email = txtEmail.Text;
                timer3.Start();
                ticks2 = 3;
                miniLoadEmail.Visible = true;
            }
            else
            {
                fromThis = false;
                number = "";
                lblInvalidEmail.Visible = true;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInvalidEmail.Visible = false;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            ticks2--;
            lblTime2.Text = ticks2.ToString();
            if (ticks2 == 1)
            {
                miniLoadMsg.Visible = false;
            }
            else if (ticks2 == 0)
            {
                timer2.Stop();
                this.Hide();
                UserSignin userSignin = new UserSignin();
                userSignin.Show();
                DummyMobileMessage m = new DummyMobileMessage();
                m.Show();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            ticks2--;
            lblTime2.Text = ticks2.ToString();
            if (ticks2 == 1)
            {
                miniLoadEmail.Visible = false;
            }
            else if (ticks2 == 0)
            {
                timer3.Stop();
                this.Hide();
                UserSignin userSignin = new UserSignin();
                userSignin.Show();
                DummyEmail m = new DummyEmail();
                m.Show();
            }
        }
    }
}
