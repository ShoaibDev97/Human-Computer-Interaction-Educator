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
    public partial class Weather : MetroFramework.Forms.MetroForm
    {
        Timer timer = new Timer();

        public Weather()
        {
            InitializeComponent();
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblAMPM.Text = DateTime.Now.ToString("tt");

            timer.Interval = 1000;
            timer.Tick += new EventHandler(t_tick);
            timer.Start();

        }

        private void t_tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lblTime.Text = time;
        }


        private void PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Label38_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void Effects_Tick(object sender, EventArgs e)
        {
            effects.Stop();
            animator1.Show(panel4);
            animator1.Show(panel2);

            animator1.Show(pHistoricalWeather);
            animator1.Show(pAvgHigh);
            animator1.Show(pAvgLow);
            animator1.Show(pHigh);
            animator1.Show(pLow);

            animator1.Show(p0);
            animator1.Show(p1);
            animator1.Show(p2);
            animator1.Show(p3);
            animator1.Show(p4);
            animator1.Show(p5);
            animator1.Show(p6);
            animator1.Show(p7);
            animator1.Show(p8);
            animator1.Show(p9);
            animator1.Show(p10);

            animator1.Show(p00);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            lblTemperatureNumber.Text = "33";
            lblDegree.Text = "°C";
            btnF.Visible = true;
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            lblTemperatureNumber.Text = "91";
            lblDegree.Text = "°F";
            btnF.Visible = false;
            btnC.Visible = true;
        }

        private void LblToday_Click(object sender, EventArgs e)
        {
            lblToday.ForeColor = Color.Red;
            panelTommorow.Visible = false;
            panel10Days.Visible = false;
            barTomorrow.Visible = false;
            barToday.Visible = true;
            bar10Days.Visible = false;
            lblTomorrow.ForeColor = Color.FromArgb(64, 64, 64);
            lbl10Days.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void LblTomorrow_Click(object sender, EventArgs e)
        {
            lblToday.ForeColor = Color.FromArgb(64, 64, 64);
            lblTomorrow.ForeColor =  Color.Red;
            panelTommorow.Visible = true;
            barTomorrow.Visible = true;
            panel10Days.Visible = false;
            barToday.Visible = false;
            bar10Days.Visible = false;
            lbl10Days.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void Lbl10Days_Click(object sender, EventArgs e)
        {
            lblToday.ForeColor = Color.FromArgb(64, 64, 64);
            lblTomorrow.ForeColor = Color.FromArgb(64, 64, 64);
            lbl10Days.ForeColor =  Color.Red;
            panel10Days.Visible = true;
            barTomorrow.Visible = false;
            barToday.Visible = false;
            bar10Days.Visible = true;
        }

        private void PicBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
