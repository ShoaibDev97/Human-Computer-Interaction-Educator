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
    public partial class SecurityCode : MetroFramework.Forms.MetroForm
    {
        public static string cipher = "";
        public static bool passfail = false;

        private int ticks1 = 5;
        private int ticks2 = 8;

        private bool SendMsgButton = false;
        private bool SendEmailButton = false;

        public SecurityCode(string receivingUserName)
        {
            InitializeComponent();
            btnShownUserName.ButtonText = receivingUserName;
            btnShowUserName.ButtonText = receivingUserName;
        }

        private void TxtEnterCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtEnterCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnterCode.Text))
            {
                lblEnterCode.Visible = false;
            }
            else
            {
                lblEnterCode.Visible = true;
            }
        }

        private void BtnSendMsg_Click(object sender, EventArgs e)
        {
            SendMsgButton = true;
            timer1.Start();
            ticks1 = 5;
            animator1.Hide(panelOptions);
            //panelOptions.Visible = false;
            picWait.Visible = true;
            lblPleaseWait.Visible = true;
            lblTryAnotherWay.Visible = false;
            lblResendCode.Visible = false;
            lblDidntReceive.Visible = false;
            btnVerifyCode.Enabled = false;
            txtEnterCode.Enabled = false;
            bunifuSeparator1.Visible = false;
            picBack.Visible = false;
            lblBack.Visible = false;
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            SendEmailButton = true;
            timer1.Start();
            ticks1 = 5;
            animator1.Hide(panelOptions);
            //panelOptions.Visible = false;
            picWait.Visible = true;
            lblPleaseWait.Visible = true;
            lblTryAnotherWay.Visible = false;
            lblResendCode.Visible = false;
            lblDidntReceive.Visible = false;
            btnVerifyCode.Enabled = false;
            txtEnterCode.Enabled = false;
            bunifuSeparator1.Visible = false;
            picBack.Visible = false;
            lblBack.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks1--;
            lblTimer1.Text = ticks1.ToString();
            if (ticks1 == 2)
            {
                picWait.Visible = false;
            }
            else if (ticks1 == 1)
            {
                lblPleaseWait.Visible = false;
                lblTryAnotherWay.Visible = true;
                lblResendCode.Visible = true;
                lblDidntReceive.Visible = true;
                btnVerifyCode.Enabled = true;
                txtEnterCode.Enabled = true;
                bunifuSeparator1.Visible = true;
                picBack.Visible = true;
                lblBack.Visible = true;
            }
            else if (ticks1 == 0)
            {
                DummyMobileMessage dummyMobileMessage = new DummyMobileMessage();
                DummyEmail dummyEmail = new DummyEmail();

                if (SendMsgButton == true)
                {
                    dummyMobileMessage.Show();
                    timer1.Stop();
                }
                if (SendEmailButton == true)
                {
                    dummyEmail.Show();
                    dummyMobileMessage.Hide();
                    timer1.Stop();
                }
            }
        }

      
        private void BtnVerifyCode_Click(object sender, EventArgs e)
        {
            if (txtEnterCode.Text == "")
            {
                lblInvalidCode.Visible = true;
            }
            else if (txtEnterCode.Text == cipher)
            {
                passfail = true;
                timer2.Start();
                txtEnterCode.Enabled = false;
                btnVerifyCode.Enabled = false;
                lblResendCode.Visible = false;
                lblDidntReceive.Visible = false;
                lblTryAnotherWay.Visible = false;
                bunifuSeparator1.Visible = false;
                picBack.Visible = false;
                lblBack.Visible = false;
                lblPleaseWait.Visible = true;
            }
            else
            {
                lblInvalidCode.Visible = true;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            ticks2--;
            lblTimer2.Text = ticks2.ToString();
            if (ticks2 == 6)
            {
                picVerify.Visible = true;
            }
            else if (ticks2 == 3)
            {
                lblPleaseWait.Visible = false;
            }
            else if (ticks2 == 2)
            {
                lblVerified.Visible = true;
            }
            else if (ticks2 == 0)
            {
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                timer2.Stop();
            }
        }

        private void LblResendCode_Click(object sender, EventArgs e)
        {
            animator1.Show(panelOptions);
        }

        private void LblTryAnotherWay_Click(object sender, EventArgs e)
        {
            txtEnterCode.Text = "";
            animator1.Show(panelOptions);
            ticks1 = 5;
        }

        private void TxtEnterCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInvalidCode.Visible = false;
        }

        private void SecurityCode_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            //userSignin.Show();
            animator1.Show(userSignin);
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            //userSignin.Show();
            animator1.Show(userSignin);
        }

        private void SecurityCode_Load(object sender, EventArgs e)
        {
            Signin s = new Signin();
            SecurityCode.cipher = s.getCipher(UserSignin.username);
           
        }

        private void PanelOptions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
