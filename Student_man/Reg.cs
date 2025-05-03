using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Student_man
{
    public partial class Reg : Form
    {
       
        
        public Reg()
        {
            InitializeComponent();



        }

        private void Reg_Load(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtpass.Text == "" || txtpasscon.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else if (txtpass.Text != txtpasscon.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else if (txtUsername.Text.Length < 5)
            {
                MessageBox.Show("Username must be at least 5 characters");
            }
            else if (txtpass.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
            }
            else
            {
                String conString = "server=localhost;user id=root;password=Sadisa123;database=lms";
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                string Query = "INSERT INTO lms.Register (UserName, Password, ConPassword ) VALUES ('" + txtUsername.Text + "','" + txtpass.Text + "','" + txtpasscon.Text + "')";
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");
                this.Hide();
                Login main = new Login();
                main.Show();
            }
        }
        public void getData()
        {
            String conString = "server=localhost;user id=root;password=Sadisa123;database=lms";
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string Query = "select Password from lms.Register where UserName = ''";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

           
        }

        private void Reg_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
