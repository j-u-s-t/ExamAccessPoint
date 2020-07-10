using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Exam_Access_Point
{
    public partial class TIMETABLE : Form
    {

        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        public TIMETABLE()
        {
            InitializeComponent();
        }

        private void TIMETABLE_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          


        }

        private void btnInsertDATE_Click(object sender, EventArgs e)
        {

        }
    }
}
