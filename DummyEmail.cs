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
    public partial class DummyEmail : Form
    {
        public DummyEmail()
        {
            InitializeComponent();
            lblCODE.Text = SecurityCode.cipher;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DummyEmail_Load(object sender, EventArgs e)
        {
            if (UserForgotPassword.fromThis)
            {
                Verifcation vf = new Verifcation();
                lblCODE.Text = vf.getPasswordfromEmail(UserForgotPassword.email);
            }
            else
            {
                Signin s = new Signin();
                lblCODE.Text = s.getCipher(UserSignin.username);
            }
        }
    }
}
