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

namespace Student_man
{
    public partial class mycouses : Form
    {
        public mycouses()
        {
            InitializeComponent();
        }

        private void comdgree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validate input fields first
            if (string.IsNullOrEmpty(comdgree.Text) ||
                string.IsNullOrEmpty(cmbmodule1.Text) ||
                string.IsNullOrEmpty(cmbmodule2.Text) ||
                string.IsNullOrEmpty(cmbmodule3.Text) ||
                string.IsNullOrEmpty(cmbmodule4.Text))
            {
                MessageBox.Show("Please select all courses and modules");
                return;
            }

            string conString = "server=localhost;user id=root;password=Sadisa123;database=lms";

            // Check if the user is already enrolled in a course
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM lms.Courses WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName); // Get username from login

                        int enrollmentCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (enrollmentCount > 0)
                        {
                            // If user is already enrolled, show a message and do not save
                            MessageBox.Show("You are already enrolled in courses. You cannot change your courses.");
                        }
                        else
                        {
                            // If user is not enrolled, save their course data
                            string insertQuery = "INSERT INTO lms.Courses (UserName, CourseName, Module1, Module2, Module3, Module4) " +
                                                "VALUES (@UserName, @CourseName, @Module1, @module2, @module3, @module4)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName); // Get username from login
                                insertCmd.Parameters.AddWithValue("@CourseName", comdgree.Text);
                                insertCmd.Parameters.AddWithValue("@Module1", cmbmodule1.Text);
                                insertCmd.Parameters.AddWithValue("@module2", cmbmodule2.Text);
                                insertCmd.Parameters.AddWithValue("@module3", cmbmodule3.Text);
                                insertCmd.Parameters.AddWithValue("@module4", cmbmodule4.Text);

                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Enrollment saved successfully.");

                                // After saving, disable fields to prevent changes
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
            // Disable fields after saving, to prevent changes
            comdgree.Enabled = false;
            cmbmodule1.Enabled = false;
            cmbmodule2.Enabled = false;
            cmbmodule3.Enabled = false;
            cmbmodule4.Enabled = false;
            btnsave.Enabled = false; // Disable the Save button
        }

        



        

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }

        private void mycouses_Load(object sender, EventArgs e)
        {
            // First check if a username is available from login
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
            string conString = "server=localhost;user id=root;password=Sadisa123;database=lms";

            // Using the connection and query to check for existing course data
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    string query = "SELECT CourseName, Module1, Module2, Module3, Module4 FROM lms.Courses WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName); // Get username from login

                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if data exists for the user
                            {
                                // Load existing course data and lock the fields
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
                                // Enable fields if no data found (i.e. the user can select and save)
                                comdgree.Enabled = true;
                                cmbmodule1.Enabled = true;
                                cmbmodule2.Enabled = true;
                                cmbmodule3.Enabled = true;
                                cmbmodule4.Enabled = true;
                                btnsave.Enabled = true; // Enable Save button for new enrollments
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
    }
}
    

