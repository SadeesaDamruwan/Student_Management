using Microsoft.VisualBasic.Logging;
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
    public partial class Createacc : Form
    {
        public Createacc()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void btncouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            mycouses main = new mycouses();
            main.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance main = new attendance();
            main.Show();
        }

        private void btntime_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timetabel main = new Timetabel();
            main.Show();

        }
    }
}
