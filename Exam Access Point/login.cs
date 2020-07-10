using System;
using System.Windows.Forms;

namespace Exam_Access_Point
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register_student rg = new register_student();
            rg.Show();
            this.Hide();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            UPDATE_STUDENTS UP = new UPDATE_STUDENTS();
            UP.Show();
            this.Hide();
        }

      
       

        private void btnExam_Click(object sender, EventArgs e)
        {
            EXAM XM = new EXAM();
            XM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
