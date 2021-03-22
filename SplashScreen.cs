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
    public partial class SplashScreen : Form
    {
        private int ticks;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            label1.Text = ticks.ToString();
            if (ticks == 10)
            {
                timer1.Stop();
                this.Hide();
                UserMode um = new UserMode();
                um.Show();
            }
        }

        private int imageNumber = 1;

        private void loadNextImage()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.png", imageNumber);
            imageNumber++;

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
