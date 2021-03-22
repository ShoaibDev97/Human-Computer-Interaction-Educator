using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Educator
{
    public partial class UserSignup : MetroFramework.Forms.MetroForm
    {
        public static string cipher = "";
        public static int key = 0;

        public static string password = "";
        bool hasError = false;

        private int ticks1 = 4;
        private int ticks2 = 5;
        private int ticks3 = 5;

        public UserSignup()
        {
            InitializeComponent();
        }

        private void BtnSignup_MouseHover(object sender, EventArgs e)
        {
            lblTC.Enabled = true;
            lblPP.Enabled = true;
        }

        private void BtnSignup_MouseLeave(object sender, EventArgs e)
        {
            lblTC.Enabled = false;
            lblPP.Enabled = false;
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length < 3)
                lblUserNameChar.Visible = true;
            else
                lblUserNameChar.Visible = false;

            if (txtUsername.Text == "")
            {
                errorProvider_Name.SetError(this.txtUsername, "Enter User Name!");
                lblUserNameChar.Visible = false;
            }
            else
            {
                errorProvider_Name.Clear();
            }
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

        private void TxtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                errorProvider_ConfirmPswd.SetError(this.txtConfirmPassword, "Enter Confirm Password!");
            }
            else
            {
                errorProvider_ConfirmPswd.Clear();
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            lblEmailSugg.Enabled = true;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            lblEmailSugg.Enabled = false;

            string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([a-zA-Z][-\\w]*[a-zA-Z]\\.)+[a-zA-Z]{3})$";
            if (Regex.IsMatch(txtEmail.Text, EmailPattern))
            {
                timer2.Start();
                ticks2 = 5;
                picTickEmail.Visible = true;
            }
            else
            {
                lblEmailChar.Visible = true;
                lblEmailSugg.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                errorProvider_Email.SetError(this.txtEmail, "Enter Email Address!");
            }
            else
            {
                errorProvider_Email.Clear();
            }
        }

        private void TxtNumber_Enter(object sender, EventArgs e)
        {
            lblNumberSugg.Enabled = true;
        }

        private void TxtNumber_Leave(object sender, EventArgs e)
        {
            lblNumberSugg.Enabled = false;

            string MobileNumberPattern = (@"\d{3} \d{7}");
            if (Regex.IsMatch(txtNumber.Text, MobileNumberPattern))
            {
                timer3.Start();
                ticks3 = 5;
                picTickNumber.Visible = true;
            }
            else
            {
                lblNumberChar.Visible = true;
                lblNumberSugg.Visible = false;
            }

            if (txtNumber.Text == "")
            {
                errorProvider_Number.SetError(this.txtNumber, "Enter Mobile Number!");
            }
            else
            {
                errorProvider_Number.Clear();
            }
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

        private void TxtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void TxtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
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

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lblUserName.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtUsername.Text = "";
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
                txtConfirmPassword.Text = "";
                txtConfirmPassword.Enabled = false;
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
                txtConfirmPassword.Enabled = true;
                lblPswd.Visible = true;
            }
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblCnfmPswd.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtConfirmPassword.Text = "";
            }
            else
            {
                lblCnfmPswd.Visible = true;
            }

            if (txtPassword.Text == txtConfirmPassword.Text)
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

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmail.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtEmail.Text = "";
            }
            else
            {
                lblEmail.Visible = true;
            }
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                lblNumber.Visible = false;
            }
            else if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("At the beginning, No White Space allowed");
                txtNumber.Text = "";
            }
            else
            {
                lblNumber.Visible = true;
            }
        }

        private void UserSignup_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            string query_city = "SELECT * FROM tblCountry";
            using (con = new SqlConnection(Program.connectionString))
            {
                DataSet ds = new DataSet();
                sda = new SqlDataAdapter(query_city, con);
                sda.Fill(ds);
                cmbCountry.DataSource = ds.Tables[0];
                cmbCountry.DisplayMember = "CountryName";
                cmbCountry.ValueMember = "CountryID";
            }
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            userSignin.Show();
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblNumberChar.Visible = false;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please Enter Numbers Only...", "Alert", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                e.KeyChar = (char)0;
                e.Handled = true;
            }
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

        private void LblBacktoUserMode_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMode um = new UserMode();
            um.Show();
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMode um = new UserMode();
            um.Show();
        }

        private void ChkverifyCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkverifyCode.Checked == true)
            {
                if (txtPassword.Text == "" && txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please! Enter password and Confirm Password first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkverifyCode.Checked = false;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please! Enter password first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkverifyCode.Checked = false;
                }
                else if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please! Enter Confirm Password first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkverifyCode.Checked = false;
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please! Enter Email Address first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkverifyCode.Checked = false;
                }
                else if (txtNumber.Text == "")
                {
                    MessageBox.Show("Please! Enter Mobile Number first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkverifyCode.Checked = false;
                }
                else
                {
                    password = txtPassword.Text;
                    TwoStepVerification twoStepVerification = new TwoStepVerification();
                    twoStepVerification.Show();
                }
            }
        }

        private void ChkQRpasscode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQRpasscode.Checked == true)
            {
                if (txtPassword.Text == "" && txtConfirmPassword.Text == "")
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

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == ""
                && txtPassword.Text == ""
                && txtConfirmPassword.Text == ""
                && txtEmail.Text == ""
                && txtNumber.Text == "")
            {
                MessageBox.Show("Please Enter All Entities first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter User Name first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Enter Confirm Password first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email Address first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNumber.Text == "")
            {
                MessageBox.Show("Please Enter Mobile Number first...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lblUserNameChar.Visible == true)
            {
                lblUserNameChar.Visible = true;
            }
            else if (lblPasswordChar.Visible == true)
            {
                lblPasswordChar.Visible = true;
            }
            else if (lblNumberChar.Visible == true)
            {
                lblNumberChar.Visible = true;
            }
            else if (lblEmailChar.Visible == true)
            {
                lblEmailChar.Visible = true;
            }
            else if (picCross.Visible == true)
            {
                picCross.Visible = true;
            }
            else
            {
                string Gender = "";
                if ((rbtnMale.Checked) || (rbtnFemale.Checked))
                {
                    if (rbtnMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else if (rbtnFemale.Checked)
                    {
                        Gender = "Female";
                    }
                    Signup signup = new Signup(txtUsername.Text, Gender, txtPassword.Text, txtEmail.Text, cmbCountry.Text, txtNumber.Text, key, cipher);
                    signup.CreateUser();

                    timer1.Start();
                    ticks1 = 4;
                    picMiniLoad.Visible = true;
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    txtConfirmPassword.Enabled = false;
                    txtEmail.Enabled = false;
                    txtNumber.Enabled = false;
                    chkQRpasscode.Enabled = false;
                    chkverifyCode.Enabled = false;
                    cmbCountry.Enabled = false;
                }
                else
                {
                     MessageBox.Show("Please select Gender....", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            lblCountry.Visible = true;
        }

        private void UserSignup_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks1--;
            lblTime.Text = ticks1.ToString();
            if (ticks1 == 1)
            {
                picMiniLoad.Visible = false;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                txtEmail.Enabled = true;
                txtNumber.Enabled = true;
                chkQRpasscode.Enabled = true;
                chkverifyCode.Enabled = true;
                cmbCountry.Enabled = true;
            }
            else if (ticks1 == 0)
            {
                timer1.Stop();
                animator1.Show(panel1);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            ticks2--;
            lblTimeValidTick.Text = ticks2.ToString();
            if (ticks2 == 1)
            {
                picTickEmail.Visible = false;
                timer2.Stop();
            }            
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblEmailSugg.Visible = true;
            lblEmailChar.Visible = false;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            ticks3--;
            lblTimeValidTick.Text = ticks3.ToString();
            if (ticks3 == 1)
            {
                picTickNumber.Visible = false;
                timer3.Stop();
            }
        }

        private void BtnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            userSignin.Show();
        }
    }
}
