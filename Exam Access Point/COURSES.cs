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
    public partial class COURSES : Form
    {
          
        
        public COURSES()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-56UHK21;Initial Catalog=EapDb;Integrated Security=True");


        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CODE,NAME,LEVEL FROM [COMPUTER_SCIENCE_COURSES]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter daapt = new SqlDataAdapter(cmd);
            daapt.Fill(dta);
            bunifuCustomDataGrid1.DataSource = dta;
            connection.Close();

        }

        private void COURSES_Load(object sender, EventArgs e)
        {
           
            display_data();

        }
    }
}

