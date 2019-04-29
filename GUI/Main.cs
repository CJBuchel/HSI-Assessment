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
        MySqlConnection Schoolcon = new MySqlConnection("server=localhost;user id=root;database=skynet;port=3308;persistsecurityinfo=True");
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;

        public Main()
        {
            InitializeComponent();
            showdata();
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
            SearchData(textBox1.Text);
        }

        public void showdata()
        {
            adpt = new MySqlDataAdapter("Select * from schoolimport", Schoolcon);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void showTimesData()
        {
            adpt = new MySqlDataAdapter("Select * From interviewTimes", Schoolcon);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void SearchData(string search)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            showdata();
        }
    }
}
