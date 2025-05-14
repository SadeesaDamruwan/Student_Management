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
    public partial class Timetabel : Form
    {
        // Dictionary to store course colors for visual differentiation
        private Dictionary<string, Color> courseColors = new Dictionary<string, Color>
        {
            { "Introduction to Computer Science", Color.LightBlue },
            { "Programming in C#", Color.LightGreen },
            { "Object Oriented Programming with Java", Color.LightPink },
            { "Algorithms and Complexity", Color.LightYellow },
            { "Mathematics for Computing", Color.LightSalmon },
            { "Human-Computer Interaction", Color.LavenderBlush }
        };

        public Timetabel()
        {
            InitializeComponent();
            InitializeTimetable();
            PopulateTimetable();
        }

        private void InitializeTimetable()
        {
            // Add header for days
            string[] days = { "Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < days.Length; i++)
            {
                Label label = new Label();
                label.Text = days[i];
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                label.BackColor = Color.LightGray;
                timetablePanel.Controls.Add(label, i, 0);
            }

            // Add time slots
            string[] timeSlots = { "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00",
                                   "13:00 - 14:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00" };

            for (int i = 0; i < timeSlots.Length; i++)
            {
                Label label = new Label();
                label.Text = timeSlots[i];
                label.Font = new Font("Arial", 9, FontStyle.Regular);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                timetablePanel.Controls.Add(label, 0, i + 1);
            }
        }

        private void PopulateTimetable()
        {
            // Static timetable data based on the courses shown in the screenshot
            AddCourse("Introduction to Computer Science", 1, 1, 2); // Monday, 9:00-11:00
            AddCourse("Programming in C#", 2, 3, 2); // Tuesday, 11:00-13:00
            AddCourse("Object Oriented Programming with Java", 3, 2, 2); // Wednesday, 10:00-12:00
            AddCourse("Algorithms and Complexity", 4, 4, 2); // Thursday, 12:00-14:00
            AddCourse("Human-Computer Interaction", 3, 6, 2); // Wednesday, 14:00-16:00
            AddCourse("Mathematics for Computing", 5, 5, 2); // Friday, 13:00-15:00
        }

        private void AddCourse(string courseName, int day, int startSlot, int duration)
        {
            Panel coursePanel = new Panel();
            coursePanel.Dock = DockStyle.Fill;
            coursePanel.BackColor = courseColors.ContainsKey(courseName) ? courseColors[courseName] : Color.White;

            Label courseNameLabel = new Label();
            courseNameLabel.Text = courseName;
            courseNameLabel.Font = new Font("Arial", 9, FontStyle.Bold);
            courseNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            courseNameLabel.Dock = DockStyle.Fill;

            coursePanel.Controls.Add(courseNameLabel);

            // Set cell spanning if duration > 1
            if (duration > 1)
            {
                timetablePanel.SetRowSpan(coursePanel, duration);
            }

            timetablePanel.Controls.Add(coursePanel, day, startSlot);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Print functionality would go here
            MessageBox.Show("Print functionality not implemented yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Createacc main = new Createacc();
            main.Show();
        }

        private void Timetabel_Load(object sender, EventArgs e)
        {

        }
    }
}