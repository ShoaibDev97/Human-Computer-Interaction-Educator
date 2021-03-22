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
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weather weather = new Weather();
            weather.Show();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignin userSignin = new UserSignin();
            userSignin.Show();
        }
    }
}
