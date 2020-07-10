using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exam_Access_Point
{
    public partial class UPDATE_STUDENTS : Form


    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-56UHK21;Initial Catalog=EapDb;Integrated Security=True");
        public UPDATE_STUDENTS()
        {
            InitializeComponent();


        }

        
        

        private void UPDATE_STUDENTS_Load(object sender, EventArgs e)
        {
            display_data();
            searchData("");
        }

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name,surname,registration_number,course_work,attendance from[ICS_221_OBJECT_ORIENTED_PROGRAMMING]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter daapt = new SqlDataAdapter(cmd);
            daapt.Fill(dta);
            bunifuCustomDataGrid1.DataSource = dta;
            connection.Close();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            searchData("");
            searchData(search.Text);
        }
        public void searchData(string valueToFind)
        {
            

            string searchQuery = "name,surname,registration_number from  CONCAT(CODE,NAME,LEVEL) LIKE '%" + valueToFind + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, connection);
            DataTable ttable = new DataTable();
            adapter.Fill(ttable);
            bunifuCustomDataGrid1.DataSource = ttable;

        }




    }
}











