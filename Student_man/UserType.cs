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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void btnuse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void btnad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }
    }
}
