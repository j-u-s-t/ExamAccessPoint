using System;
using System.Windows.Forms;

namespace Exam_Access_Point
{
    public partial class EXAM : Form
    {
        public EXAM()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();
        }

        private void EXAM_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            day.Text = System.DateTime.Now.DayOfWeek.ToString();
        }
    }
}
