namespace Student_man
{
    partial class Createacc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitle = new Label();
            lblExit = new Label();
            btnCourses = new Button();
            btnAttendance = new Button();
            btnTimetable = new Button();
            btnLogout = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelDashboard = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 58);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(14, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(274, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Student Management System";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(1007, 10);
            lblExit.Margin = new Padding(4, 0, 4, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(27, 25);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // btnCourses
            // 
            btnCourses.BackColor = Color.FromArgb(52, 152, 219);
            btnCourses.FlatAppearance.BorderSize = 0;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourses.ForeColor = Color.White;
            btnCourses.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourses.Location = new Point(0, 173);
            btnCourses.Margin = new Padding(4, 3, 4, 3);
            btnCourses.Name = "btnCourses";
            btnCourses.Padding = new Padding(12, 0, 0, 0);
            btnCourses.Size = new Size(233, 69);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "  My Courses";
            btnCourses.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCourses.UseVisualStyleBackColor = false;
            btnCourses.Click += btncouse_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(52, 152, 219);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(0, 242);
            btnAttendance.Margin = new Padding(4, 3, 4, 3);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(12, 0, 0, 0);
            btnAttendance.Size = new Size(233, 69);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "  Attendance";
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += button1_Click;
            // 
            // btnTimetable
            // 
            btnTimetable.BackColor = Color.FromArgb(52, 152, 219);
            btnTimetable.FlatAppearance.BorderSize = 0;
            btnTimetable.FlatStyle = FlatStyle.Flat;
            btnTimetable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimetable.ForeColor = Color.White;
            btnTimetable.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimetable.Location = new Point(0, 312);
            btnTimetable.Margin = new Padding(4, 3, 4, 3);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Padding = new Padding(12, 0, 0, 0);
            btnTimetable.Size = new Size(233, 69);
            btnTimetable.TabIndex = 3;
            btnTimetable.Text = "  Timetable";
            btnTimetable.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimetable.UseVisualStyleBackColor = false;
            btnTimetable.Click += btntime_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(230, 126, 34);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 450);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(233, 69);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "  Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnTimetable);
            panel2.Controls.Add(btnAttendance);
            panel2.Controls.Add(btnCourses);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 634);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4196591;
            pictureBox1.Location = new Point(58, 17);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(236, 240, 241);
            panelDashboard.Controls.Add(label2);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(233, 58);
            panelDashboard.Margin = new Padding(4, 3, 4, 3);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(817, 634);
            panelDashboard.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(246, 200);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(343, 135);
            label2.TabIndex = 0;
            label2.Text = "Welcome to \r\nStudent Management\r\nSystem";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Createacc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 692);
            Controls.Add(panelDashboard);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Createacc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label2;
    }
}