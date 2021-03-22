using MessagingToolkit.QRCode.Codec.Data;
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
    public partial class UserSignin : MetroFramework.Forms.MetroForm
    {
        public static string username = "";

        private int ticks1 = 5;
        private int ticks2 = 5;

        public UserSignin()
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

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignup userSignup = new UserSignup();
            userSignup.Show();
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

        private void UserSignin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LblGetQRpasscode_Click(object sender, EventArgs e)
        {
            timer1.Start();
            txtPassword.Text = "";
            ticks1 = 5;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            circularPictureBox1.Visible = false;
            picWait.Visible = true;
            lblWait.Visible = true;
            lblGetQRpasscode.Enabled = false;
            lblForgotPswd.Enabled = false;
            btnLogin.Enabled = false;
            bunifuSeparator1.Visible = false;
            picBack.Visible = false;
            lblBacktoUserMode.Visible = false;
            lblCreateAccount.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks1--;
            lblTime1.Text = ticks1.ToString();
            if (ticks1 == 2)
            {
                picWait.Visible = false;
            }
            else if (ticks1 == 1)
            {
                lblWait.Visible = false;
                lblDone.Visible = true;
            }
            else if (ticks1 == 0)
            {
                lblDone.Visible = false;
                timer1.Stop();
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                picQRcode.Visible = true;
                using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        picQRcode.Image = Image.FromFile(openFileDialog.FileName);
                        MessagingToolkit.QRCode.Codec.QRCodeDecoder qrCodeDecoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                        txtPassword.Text = qrCodeDecoder.Decode(new QRCodeBitmapImage(picQRcode.Image as Bitmap));
                        timer2.Start();
                        ticks2 = 5;
                    }
                    else
                    {
                        picQRcode.Visible = false;
                        circularPictureBox1.Visible = true;
                        lblGetQRpasscode.Enabled = true;
                        btnLogin.Enabled = true;
                        bunifuSeparator1.Visible = true;
                        picBack.Visible = true;
                        lblBacktoUserMode.Visible = true;
                        lblForgotPswd.Enabled = true;
                        lblCreateAccount.Enabled = true;
                    }
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            ticks2--;
            lblTimer2.Text = ticks2.ToString();
            if (picQRcode.Visible == true)
            {
                if (ticks2 == 2)
                {
                    btnLogin.Enabled = true;
                    bunifuSeparator1.Visible = true;
                    picBack.Visible = true;
                    lblBacktoUserMode.Visible = true;
                    lblCreateAccount.Enabled = true;
                }
                else if (ticks2 == 1)
                {
                    picQRcode.Visible = false;
                    circularPictureBox1.Visible = true;
                    lblGetQRpasscode.Enabled = true;
                    lblForgotPswd.Enabled = true;
                    timer2.Stop();
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();

            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please! Enter UserName and Password", "Alert", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                if (signin.checkCipher(txtUsername.Text))
                {
                    //Open Cipher Form               
                    if (signin.AuthenticateUser(txtUsername.Text, txtPassword.Text))
                    {
                        this.Hide();
                        username = txtUsername.Text;
                        SecurityCode sc = new SecurityCode(txtUsername.Text);
                        sc.Show();
                        if (SecurityCode.passfail)
                        {
                            if (signin.AuthenticateUser(txtUsername.Text, txtPassword.Text))
                            {
                                UserSignin.username = txtUsername.Text;
                                this.Hide();
                            }
                            else
                            {
                                UserSignin.username = "";
                                MessageBox.Show("Invalid Username and Password", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    if (signin.AuthenticateUser(txtUsername.Text, txtPassword.Text))
                    {
                        this.Hide();
                        MainMenu mm1 = new MainMenu();
                        mm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }

        private void LblForgotPswd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please! Enter User Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                UserForgotPassword userForgotPassword = new UserForgotPassword(txtUsername.Text);
                userForgotPassword.Show();
            }
        }

        private void UserSignin_Load(object sender, EventArgs e)
        {
            animator1.Show(metroLink2);
            animator1.Show(bunifuImageButton1);
            animator1.Show(bunifuImageButton2);
            animator1.Show(bunifuImageButton3);
            animator1.Show(bunifuImageButton4);
        }
    }
}
