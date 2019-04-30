using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class Main : Form
    {
        MySqlConnection Schoolcon = new MySqlConnection("server=localhost;user id=root;database=skynet;port=3306;persistsecurityinfo=True");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;

        public Main()
        {
            InitializeComponent();
            showdata();
            dataGridView2.Hide();
            dataGridView3.Hide();
        }

        void entity101vision_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddData AD = new AddData();
            AD.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            showTimesData();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchInterviewData(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchInterviewTimes(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SearchUsers(textBox3.Text);
        }


        public void showdata()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport", Schoolcon);
            dt = new DataTable();
            adpt.Fill(dt);

            // Data Shown
            dataGridView1.Show();
            dataGridView1.DataSource = dt;
            dataGridView2.Hide();
            dataGridView3.Hide();

            // TextBox Shown
            textBox1.Show();
            textBox2.Hide();
            textBox3.Hide();
        }

        public void showUserData()
        {
            adpt = new MySqlDataAdapter("Select * From Users", Schoolcon);
            dt = new DataTable();
            adpt.Fill(dt);

            // Data Shown
            dataGridView3.Show();
            dataGridView3.DataSource = dt;
            dataGridView1.Hide();
            dataGridView2.Hide();

            // TextBox Shown
            textBox3.Show();
            textBox1.Hide();
            textBox2.Hide();
        }

        public void showTimesData()
        {
            adpt = new MySqlDataAdapter("Select * From interviewTimes", Schoolcon);
            dt = new DataTable();
            adpt.Fill(dt);

            // Data Shown
            dataGridView2.Show();
            dataGridView2.DataSource = dt;
            dataGridView1.Hide();
            dataGridView3.Hide();

            // TextBox Shown
            textBox2.Show();
            textBox1.Hide();
            textBox3.Hide();
        }

        public void SearchInterviewData(string search)
        {
           // Teacher Title
            string query = "select * FROM schoolimport WHERE " +
                "TeacherCode LIKE '%" + search + "%'" +
                " OR TeacherTitle LIKE '%" + search + "%'" +
                " OR TeacherSurname LIKE '%" + search + "%'" +
                " OR SubjectCode LIKE '%" + search + "%'" +
                " OR SubjectName LIKE '%" + search + "%'" +
                " OR StudentNumber LIKE '%" + search + "%'" +
                " OR StudentFirstName LIKE '%" + search + "%'" +
                " OR StudentSurname LIKE '%" + search + "%'" +
                " OR StudentYear LIKE '%" + search + "%'" +
                " OR ParentNumber LIKE '%" + search + "%'" +
                " OR ParentFirstName LIKE '%" + search + "%'" +
                " OR ParentSurname LIKE '%" + search + "%'" +
                " OR ParentEmail LIKE '%" + search + "%'" +
                "";

            // Data Query (Names)
            adpt = new MySqlDataAdapter(query, Schoolcon);

            // Data Show/Fill
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void SearchInterviewTimes(string search)
        {
            // Teacher Title
            string query = "select * FROM interviewTimes WHERE " +
                "InterviewNumber LIKE '%" + search + "%'" +
                " OR StartTime LIKE '%" + search + "%'" +
                " OR EndTime LIKE '%" + search + "%'" +

                " OR TeacherCode LIKE '%" + search + "%'" +
                " OR TeacherSurname LIKE '%" + search + "%'" +
                " OR SubjectName LIKE '%" + search + "%'" +
                " OR StudentFirstName LIKE '%" + search + "%'" +
                " OR StudentSurname LIKE '%" + search + "%'" +
                " OR ParentFirstName LIKE '%" + search + "%'" +
                " OR ParentSurname LIKE '%" + search + "%'" +
                "";

            // Data Query (Names)
            adpt = new MySqlDataAdapter(query, Schoolcon);

            // Data Show/Fill
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public void SearchUsers(string search)
        {
            // Teacher Title
            string query = "select * FROM users WHERE " +
                "USERNAME LIKE '%" + search + "%'" +
                " OR PASSWORD LIKE '%" + search + "%'" +
                "";

            // Data Query (Names)
            adpt = new MySqlDataAdapter(query, Schoolcon);

            // Data Show/Fill
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            showUserData();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AddUser AU = new AddUser();
            AU.Show();
        }
    }
}
