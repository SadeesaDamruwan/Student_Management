using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;

namespace Student_man
{
    public partial class Login : Form
    {
        public string username;
        public string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtpass.Text;

            String conString = "server=localhost;user id=root;password=Sadisa123;database=lms";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string Query = "select Password from lms.Register where UserName = '" + username +"'";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                if(reader.GetString(0) == password)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    Createacc main = new Createacc();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password does not exist");
                }
            }

            else
            {
                MessageBox.Show("Username or Password does not exist");
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpass.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg main = new Reg();
            main.Show();
        }
    }
}

