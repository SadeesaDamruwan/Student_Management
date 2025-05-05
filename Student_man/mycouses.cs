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
            String conString = "server=localhost;user id=root;password=Sadisa123;database=lms";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            string Query = "INSERT INTO lms.Courses (CourseName, Module1, Module2, Module3, Module4) VALUES (@CourseName, @Module1, @Module2, @Module3, @Module4)";

            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@CourseName", comdgree.Text);
            cmd.Parameters.AddWithValue("@Module1", cmbmodule1.Text);
            cmd.Parameters.AddWithValue("@Module2", cmbmodule2.Text);
            cmd.Parameters.AddWithValue("@Module3", cmbmodule3.Text);
            cmd.Parameters.AddWithValue("@Module4", cmbmodule4.Text);


            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your Couses has been saved Misabery");
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }
    }
}
