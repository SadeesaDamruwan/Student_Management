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
    public partial class attendance : Form
    {
        private string conString = "server=localhost;user id=root;password=Sadisa123;database=lms";

        public attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
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

            
            dateTimePicker1.Value = DateTime.Today;
        }

        private void LoadUserCourseData()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    string query = "SELECT Module1, Module2, Module3, Module4 FROM lms.Courses WHERE UserName = @UserName";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);

                        con.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                cmbModule.Items.Clear();

                                
                                cmbModule.Items.Add(reader["Module1"].ToString());
                                cmbModule.Items.Add(reader["Module2"].ToString());
                                cmbModule.Items.Add(reader["Module3"].ToString());
                                cmbModule.Items.Add(reader["Module4"].ToString());

                                if (cmbModule.Items.Count > 0)
                                {
                                    cmbModule.SelectedIndex = 0;
                                }
                            }
                            else
                            {
                                MessageBox.Show("You have not enrolled in any courses yet. Please enroll in courses first.");
                                this.Close();
                                mycouses coursesForm = new mycouses();
                                coursesForm.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cmbModule.Text))
            {
                MessageBox.Show("Please select a module");
                return;
            }

            
            string selectedModule = cmbModule.Text;
            DateTime selectedDate = dateTimePicker1.Value.Date;

            
            if (IsAttendanceAlreadyMarked(selectedModule, selectedDate))
            {
                MessageBox.Show("Attendance for this module has already been marked for the selected date.");
                return;
            }

           
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string insertQuery = "INSERT INTO lms.Attendance (UserName, ModuleName, AttendanceDate, Status) " +
                                        "VALUES (@UserName, @ModuleName, @AttendanceDate, @Status)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);
                        cmd.Parameters.AddWithValue("@ModuleName", selectedModule);
                        cmd.Parameters.AddWithValue("@AttendanceDate", selectedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Status", "Present");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Attendance marked successfully.");

                        
                        LoadAttendanceHistory();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error marking attendance: " + ex.Message);
                }
            }
        }

        private bool IsAttendanceAlreadyMarked(string moduleName, DateTime date)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM lms.Attendance WHERE UserName = @UserName " +
                                  "AND ModuleName = @ModuleName AND AttendanceDate = @AttendanceDate";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);
                        cmd.Parameters.AddWithValue("@ModuleName", moduleName);
                        cmd.Parameters.AddWithValue("@AttendanceDate", date.ToString("yyyy-MM-dd"));

                        con.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking attendance: " + ex.Message);
                    return false;
                }
            }
        }

        private void LoadAttendanceHistory()
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    string query = "SELECT ModuleName, AttendanceDate, Status FROM lms.Attendance " +
                                  "WHERE UserName = @UserName ORDER BY AttendanceDate DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserName", Login.LoggedInUserName);

                        con.Open();

                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading attendance history: " + ex.Message);
                }
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            LoadAttendanceHistory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }
    }
}