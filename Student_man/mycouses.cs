using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_man
{
    public partial class mycouses : Form
    {
        public mycouses()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form_Load);
        }
        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayWelcomeMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading welcome message: {ex.Message}");
            }
        }

        private void DisplayWelcomeMessage()
        {

            string conString = "server=localhost;user id=root;password=Asdf@123;database=lms";


            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {

                    if (con == null)
                    {
                        lblWelcome.Text = $"Welcome, {Login.LoggedInUserName}!";
                        return;
                    }


                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    string query = "SELECT UserName FROM lms.Register WHERE UserName = @UserName";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);


                        object result = cmd.ExecuteScalar();
                        string userName = result != null ? result.ToString() : Login.LoggedInUserName;


                        lblWelcome.Text = $"Welcome, {userName}!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");

                    lblWelcome.Text = $"Welcome, {Login.LoggedInUserName}!";
                }
                finally
                {

                    if (con != null && con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

            }

        }

        private void PageLoad(object sender, EventArgs e)
        {

        }

        private void comdgree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(comdgree.Text) ||
                string.IsNullOrEmpty(cmbmodule1.Text) ||
                string.IsNullOrEmpty(cmbmodule2.Text) ||
                string.IsNullOrEmpty(cmbmodule3.Text) ||
                string.IsNullOrEmpty(cmbmodule4.Text))
            {
                MessageBox.Show("Please select all courses and modules");
                return;
            }

            string conString = "server=localhost;user id=root;password=Asdf@123;database=lms";


            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM lms.Courses WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);

                        int enrollmentCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (enrollmentCount > 0)
                        {

                            MessageBox.Show("You are already enrolled in courses. You cannot change your courses.");
                        }
                        else
                        {

                            string insertQuery = "INSERT INTO lms.Courses (UserName, CourseName, Module1, Module2, Module3, Module4) " +
                                                "VALUES (@UserName, @CourseName, @Module1, @module2, @module3, @module4)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);
                                insertCmd.Parameters.AddWithValue("@CourseName", comdgree.Text);
                                insertCmd.Parameters.AddWithValue("@Module1", cmbmodule1.Text);
                                insertCmd.Parameters.AddWithValue("@module2", cmbmodule2.Text);
                                insertCmd.Parameters.AddWithValue("@module3", cmbmodule3.Text);
                                insertCmd.Parameters.AddWithValue("@module4", cmbmodule4.Text);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Enrollment saved successfully.");


                                DisableFormControls();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DisableFormControls()
        {

            comdgree.Enabled = false;
            cmbmodule1.Enabled = false;
            cmbmodule2.Enabled = false;
            cmbmodule3.Enabled = false;
            cmbmodule4.Enabled = false;
            btnsave.Enabled = false;
        }







        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }

        private void mycouses_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Login.LoggedInUserName))
            {
                MessageBox.Show("Error: No user is logged in. Please login first.");
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
                return;
            }

            LoadUserCourseData();
        }

        private void LoadUserCourseData()
        {
            string conString = "server=localhost;user id=root;password=Asdf@123;database=lms";


            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    string query = "SELECT CourseName, Module1, Module2, Module3, Module4 FROM lms.Courses WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);

                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                comdgree.Text = reader["CourseName"].ToString();
                                cmbmodule1.Text = reader["Module1"].ToString();
                                cmbmodule2.Text = reader["Module2"].ToString();
                                cmbmodule3.Text = reader["Module3"].ToString();
                                cmbmodule4.Text = reader["Module4"].ToString();

                                // Disable form controls
                                DisableFormControls();
                            }
                            else
                            {

                                comdgree.Enabled = true;
                                cmbmodule1.Enabled = true;
                                cmbmodule2.Enabled = true;
                                cmbmodule3.Enabled = true;
                                cmbmodule4.Enabled = true;
                                btnsave.Enabled = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading course data: " + ex.Message);
                }
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {


        }


        private void panelCourseInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

