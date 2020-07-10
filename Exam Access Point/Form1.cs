using System;
using System.Windows.Forms;

namespace Exam_Access_Point
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
            gunaProgressBar1.Value = 0;
            timer1.Start();
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Increment(10);
            gunaLabel1.Text = gunaProgressBar1.ProgressPercentText;


            if (gunaProgressBar1.Value >= gunaProgressBar1.Maximum)
            {
                timer1.Stop();
                LOG_IN l = new LOG_IN();
                l.Show();
                this.Hide();
            }
        }

       
    }
}



