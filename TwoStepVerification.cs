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
    public partial class TwoStepVerification : MetroFramework.Forms.MetroForm
    {
        Random rnd = new Random();
        int randomNumber;

        private int ticks = 5;


        public TwoStepVerification()
        {
            InitializeComponent();
            txtPassword.Text = UserSignup.password;
        }

        CeasarCipher cc = new CeasarCipher();
        private void BtnSecureAccount_Click(object sender, EventArgs e)
        {
            randomNumber = rnd.Next(10, 50);
            lblSecretKey.Text = randomNumber.ToString();
            UserSignup.key = int.Parse(lblSecretKey.Text);
            UserSignup.cipher = cc.Encrypt(int.Parse(lblSecretKey.Text), txtPassword.Text);

            timer1.Start();
            picWait.Visible = true;
            btnSecureAccount.Enabled = false;
            btnSecureAccount.Text = "Verifying...";
            lblCancelOrBack.Visible = false;
            picBack.Visible = false;
            bunifuSeparator1.Visible = false;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTime.Text = ticks.ToString();
            if (ticks == 2)
            {
                picWait.Visible = false;
                btnSecureAccount.Text = "Wait a second...";
            }
            if (ticks == 1)
            {
                timer1.Stop();
                btnSecureAccount.Text = "Done!";
                picSecure.Visible = true;
                lblSecureStatus.Visible = true;
                lblCancelOrBack.Visible = true;
                lblCancelOrBack.Text = "Back to Signup form... Click here";
                picBack.Visible = true;
                bunifuSeparator1.Visible = true;
                
            }
        }

        private void LblCancelOrBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignup userSignup = new UserSignup();
            userSignup.chkverifyCode.Checked = false;
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignup userSignup = new UserSignup();
            userSignup.chkverifyCode.Checked = false;
        }
    }
}
