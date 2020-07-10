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
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if(sideBar.Width == 356 )
            {
                sideBar.Width = 90;
                sideBarWrapper.Width = 90;
            }
            else
            {
                sideBar.Width = 356 ;
                sideBarWrapper.Width = 410; 
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            STUDENTS std = new STUDENTS();
           
            std.Show();
            this.Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            COURSES CRS = new COURSES();
            CRS.Show();
            this.Hide();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            EXAM EXM = new EXAM();
            this.Hide();
            EXM.Show();
             
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            TIMETABLE tm = new TIMETABLE();
            tm.Show();
            this.Hide();
        }
    }
}
