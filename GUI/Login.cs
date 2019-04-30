using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GUI
{
    public partial class Login : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;

        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "admin")
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Password Is Incorrect");
                }
            }
            else if (textBox1.Text != "admin")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=skynet;port=3306;persistsecurityinfo=True");
                con.Open();
                //MySqlCommand cmd = new MySqlCommand("select * from users where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) From users where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Main ss = new Main();
                    ss.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username and/or Password Is Incorrect");
            }
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
