using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using WinFormCharpWebCam;



namespace Exam_Access_Point
{
    public partial class register_student : Form
    {
        WebCam webcam;


        public register_student()
        {

            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-56UHK21;Initial Catalog=EapDb;Integrated Security=True");



        private void GetStudentsRecord()
        {


            SqlCommand cmd = new SqlCommand("Select *from Students", con);
            DataTable dt = new DataTable();

            con.Open();
            // SqlDataReader sdr = cmd.ExecuteReader();
            // dt.Load(sdr);
            con.Close();

            //            studentRecordDgv.DataSource = dt;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into students VALUES (@registration_number, @name, @surname, @gender, @program, @level, @picture)", con);





                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@program", cboProgram.Text);
                cmd.Parameters.AddWithValue("@level", cboLevel.Text);
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmd.Parameters.AddWithValue("@picture", pic);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                if (cboLevel.Text.Equals("2.2"))
                {
                    SqlCommand cmd1 = new SqlCommand("insert into ICS_221_OBJECT_ORIENTED_PROGRAMMING VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd2 = new SqlCommand("insert into ICS_222_WEB_PROGRAMMING_CONCEPTS VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd22 = new SqlCommand("insert into TEC_401_TLC VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd21 = new SqlCommand("insert into ICS_223_ADVANCED_DATABASES VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd224 = new SqlCommand("insert into ICS_224_DESIGN_AND_ANALYSIS_OF_ALGORITHMS VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd225 = new SqlCommand("insert into ICS_225_MICROPOCESSORS_AND_EMBEDDED_SYSTEMS VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd226 = new SqlCommand("insert into ICS_226_NUMERICAL_ANALYSIS VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand E221 = new SqlCommand("insert into EEE_221_DIGITAL_SIGNAL_PROCESSING VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);
                    SqlCommand cmd227 = new SqlCommand("insert into  ICS_227_COMPUTER_GRAPHICS VALUES(@registration_number, @name, @surname,@course_work, @attendance)", con);







                    // OOP

                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd1.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd1.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd1.Parameters.AddWithValue("@course_work", "");
                    cmd1.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    //insert into ICS_222_WEB_PROGRAMMING_CONCEPTS 
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd2.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd2.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd2.Parameters.AddWithValue("@course_work", "");
                    cmd2.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();


                    //insert into TEC 
                    cmd22.CommandType = CommandType.Text;
                    cmd22.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd22.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd22.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd22.Parameters.AddWithValue("@course_work", "");
                    cmd22.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd22.ExecuteNonQuery();
                    con.Close();


                    //insert into ADB
                    cmd21.CommandType = CommandType.Text;
                    cmd21.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd21.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd21.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd21.Parameters.AddWithValue("@course_work", "");
                    cmd21.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd21.ExecuteNonQuery();
                    con.Close();

                    //insert into ALGORITHMS
                    cmd224.CommandType = CommandType.Text;
                    cmd224.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd224.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd224.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd224.Parameters.AddWithValue("@course_work", "");
                    cmd224.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd224.ExecuteNonQuery();
                    con.Close();


                    //insert into MP
                    cmd225.CommandType = CommandType.Text;
                    cmd225.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd225.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd225.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd225.Parameters.AddWithValue("@course_work", "");
                    cmd225.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd225.ExecuteNonQuery();
                    con.Close();

                    //insert into 226
                    cmd226.CommandType = CommandType.Text;
                    cmd226.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd226.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd226.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd226.Parameters.AddWithValue("@course_work", "");
                    cmd226.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd226.ExecuteNonQuery();
                    con.Close();


                    //insert into 226
                    E221.CommandType = CommandType.Text;
                    E221.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    E221.Parameters.AddWithValue("@name", txtStudentName.Text);
                    E221.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    E221.Parameters.AddWithValue("@course_work", "");
                    E221.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    E221.ExecuteNonQuery();
                    con.Close();


                    //insert into 227 GRAPHICS
                    cmd227.CommandType = CommandType.Text;
                    cmd227.Parameters.AddWithValue("@registration_number", txtRegistrationNumber.Text);
                    cmd227.Parameters.AddWithValue("@name", txtStudentName.Text);
                    cmd227.Parameters.AddWithValue("@surname", txtStudentSurname.Text);
                    cmd227.Parameters.AddWithValue("@course_work", "");
                    cmd227.Parameters.AddWithValue("@attendance", "");

                    con.Open();
                    cmd227.ExecuteNonQuery();
                    con.Close();









                }


                MessageBox.Show("STUDENT SUCCESSFULLY REGISTERD", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();





            }




        }


        private bool IsValid()
        {
            if (txtStudentName.Text == string.Empty)


            {
                MessageBox.Show("Student name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void register_student_Load(object sender, EventArgs e)
        {

            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            webcam.Start();


        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {


            pictureBox1.Image = pictureBox1.Image;
            webcam.Stop();
        }
    }



}

