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
    public partial class LOG_IN : Form
    {
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("USERNAME"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "USERNAME";
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text.Equals("PASSWORD"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "PASSWORD";
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DASHBOARD DD = new DASHBOARD();
            DD.Show();
            this.Hide();
        }
    }
}
