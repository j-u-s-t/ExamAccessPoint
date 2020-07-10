using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Access_Point
{
    public partial class STUDENTS : Form
    {
        public STUDENTS()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            register_student RSTD = new register_student();
            RSTD.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            UPDATE_STUDENTS UPD = new UPDATE_STUDENTS();
            UPD.Show();
            this.Hide();
        }

        private void STUDENTS_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
