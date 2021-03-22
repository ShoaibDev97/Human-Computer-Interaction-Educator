using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Educator
{
    public partial class UpdatePassword : MetroFramework.Forms.MetroForm
    {
        private int ticks = 3;

        public UpdatePassword(string receivingUserName)
        {
            InitializeComponent();
            btnShowUserName.ButtonText = receivingUserName;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 6)
                lblPasswordChar.Visible = true;
            else
                lblPasswordChar.Visible = false;

            if (txtPassword.Text == "")
            {
                errorProvider_Password.SetError(this.txtPassword, "Enter Paassword!");
                lblPasswordChar.Visible = false;
            }
            else
            {
                errorProvider_Password.Clear();
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtConfirmPswd.Text = "";
                txtConfirmPswd.Enabled = false;
                lblPswd.Visible = false;
                picCross.Visible = false;
                picTick.Visible = false;
                errorProvider_ConfirmPswd.Clear();
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtPassword.Text = "";
            }
            else
            {
                txtConfirmPswd.Enabled = true;
                lblPswd.Visible = true;
            }
        }

        private void TxtConfirmPswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtConfirmPswd_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPswd.Text == "")
            {
                errorProvider_ConfirmPswd.SetError(this.txtConfirmPswd, "Enter Confirm Password!");
            }
            else
            {
                errorProvider_ConfirmPswd.Clear();
            }
        }

        private void TxtConfirmPswd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPswd.Text))
            {
                lblConfirmPswd.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPswd.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtConfirmPswd.Text = "";
            }
            else
            {
                lblConfirmPswd.Visible = true;
            }

            if (txtPassword.Text == txtConfirmPswd.Text)
            {
                picTick.Visible = true;
                picCross.Visible = false;
            }
            else
            {
                picCross.Visible = true;
                picTick.Visible = false;
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

        private void ChkQRpasscode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQRpasscode.Checked == true)
            {
                if (txtPassword.Text == "" && txtConfirmPswd.Text == "")
                {
                    MessageBox.Show("Please! Enter Password and Confirm Password first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkQRpasscode.Checked = false;
                }
                else
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "JPEG|*.jpg", ValidateNames = true })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            MessagingToolkit.QRCode.Codec.QRCodeEncoder qrCodeEncoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                            qrCodeEncoder.QRCodeScale = 8;
                            Bitmap bmp = qrCodeEncoder.Encode(txtPassword.Text);
                            bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        }
                        else
                        {
                            chkQRpasscode.Checked = false;
                            MessageBox.Show("Hello User, by the use of Additional Security you make your Account more secure.\n Please use Additional Security methods in your account(Optional).\n Thank you!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtConfirmPswd.Text == "")
            {
                MessageBox.Show("Please! Enter Password and Confirm Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please! Enter Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirmPswd.Text == "")
            {
                MessageBox.Show("Please! Enter Confirm Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblPasswordChar.Visible == true)
            {
                lblPasswordChar.Visible = true;
            }
            else if (picCross.Visible == true)
            {
                picCross.Visible = true;
            }
            else
            {
                timer1.Start();
                picMiniLoad.Visible = true;
                txtPassword.Enabled = false;
                txtConfirmPswd.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            lblTime.Text = ticks.ToString();
            if (ticks == 1)
            {
                picMiniLoad.Visible = false;
                txtPassword.Enabled = true;
                txtConfirmPswd.Enabled = true;
            }
            else if (ticks == 0)
            {
                timer1.Stop();

                animator1.Show(panel1);
            }
        }
    }
}
