using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;

namespace Student_man
{
    public partial class Login : Form
    {
        public string username;
        public string password;
        public static string LoggedInUserName;
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
            // Get username and password from text fields
            username = txtUsername.Text.Trim();
            password = txtpass.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            String conString = "server=localhost;user id=root;password=Asdf@123;database=lms";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    // Use parameterized query to prevent SQL injection
                    string Query = "SELECT Password FROM lms.Register WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(Query, con))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@UserName", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader.GetString(0);

                                if (storedPassword == password)
                                {
                                    // Set the static LoggedInUserName variable for use in other forms
                                    LoggedInUserName = username;

                                    MessageBox.Show("Login Successful");
                                    this.Hide();
                                    Createacc main = new Createacc();
                                    main.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Username or Password is incorrect");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username does not exist");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

