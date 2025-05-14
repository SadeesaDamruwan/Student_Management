namespace Student_man
{
    partial class mycouses
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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblExit = new Label();
            panelMain = new Panel();
            lblWelcome = new Label();
            panelCourseInfo = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comdgree = new ComboBox();
            cmbmodule1 = new ComboBox();
            cmbmodule2 = new ComboBox();
            cmbmodule3 = new ComboBox();
            cmbmodule4 = new ComboBox();
            btnsave = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            panelCourseInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 123);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 19);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(97, 37);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 39);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Course Enrollment";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(1160, 13);
            lblExit.Margin = new Padding(5, 0, 5, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 31);
            lblExit.TabIndex = 0;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(240, 244, 247);
            panelMain.Controls.Add(lblWelcome);
            panelMain.Controls.Add(panelCourseInfo);
            panelMain.Controls.Add(btnsave);
            panelMain.Controls.Add(btnBack);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 123);
            panelMain.Margin = new Padding(5, 4, 5, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1200, 800);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(64, 64, 64);
            lblWelcome.Location = new Point(62, 61);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(127, 29);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome, ";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // panelCourseInfo
            // 
            panelCourseInfo.BackColor = Color.White;
            panelCourseInfo.BorderStyle = BorderStyle.FixedSingle;
            panelCourseInfo.Controls.Add(label6);
            panelCourseInfo.Controls.Add(label5);
            panelCourseInfo.Controls.Add(label4);
            panelCourseInfo.Controls.Add(label3);
            panelCourseInfo.Controls.Add(label2);
            panelCourseInfo.Controls.Add(label1);
            panelCourseInfo.Controls.Add(comdgree);
            panelCourseInfo.Controls.Add(cmbmodule1);
            panelCourseInfo.Controls.Add(cmbmodule2);
            panelCourseInfo.Controls.Add(cmbmodule3);
            panelCourseInfo.Controls.Add(cmbmodule4);
            panelCourseInfo.Location = new Point(66, 153);
            panelCourseInfo.Margin = new Padding(5, 4, 5, 4);
            panelCourseInfo.Name = "panelCourseInfo";
            panelCourseInfo.Size = new Size(1066, 491);
            panelCourseInfo.TabIndex = 6;
            panelCourseInfo.Paint += panelCourseInfo_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(31, 23);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(357, 25);
            label6.TabIndex = 12;
            label6.Text = "SELECT YOUR COURSE DETAILS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 400);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 11;
            label5.Text = "Module 4:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 323);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 10;
            label4.Text = "Module 3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 247);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 9;
            label3.Text = "Module 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 169);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 8;
            label2.Text = "Module 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 92);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 7;
            label1.Text = "Degree Course:";
            // 
            // comdgree
            // 
            comdgree.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comdgree.FormattingEnabled = true;
            comdgree.Items.AddRange(new object[] { "Software Engineering", "Computer Science", "Information Technology", "Cyber Security", "Data Science", "Artificial Intelligence" });
            comdgree.Location = new Point(226, 88);
            comdgree.Margin = new Padding(5, 4, 5, 4);
            comdgree.Name = "comdgree";
            comdgree.Size = new Size(798, 32);
            comdgree.TabIndex = 1;
            comdgree.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // cmbmodule1
            // 
            cmbmodule1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmodule1.FormattingEnabled = true;
            cmbmodule1.Items.AddRange(new object[] { "Programming Fundamentals", "Object Oriented Programming", "Database Systems", "Web Development", "Mobile Application Development", "Networking Fundamentals", "Operating Systems", "Software Project Management" });
            cmbmodule1.Location = new Point(226, 164);
            cmbmodule1.Margin = new Padding(5, 4, 5, 4);
            cmbmodule1.Name = "cmbmodule1";
            cmbmodule1.Size = new Size(798, 32);
            cmbmodule1.TabIndex = 2;
            // 
            // cmbmodule2
            // 
            cmbmodule2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmodule2.FormattingEnabled = true;
            cmbmodule2.Items.AddRange(new object[] { "Programming Fundamentals", "Object Oriented Programming", "Database Systems", "Web Development", "Mobile Application Development", "Networking Fundamentals", "Operating Systems", "Software Project Management" });
            cmbmodule2.Location = new Point(226, 241);
            cmbmodule2.Margin = new Padding(5, 4, 5, 4);
            cmbmodule2.Name = "cmbmodule2";
            cmbmodule2.Size = new Size(798, 32);
            cmbmodule2.TabIndex = 3;
            // 
            // cmbmodule3
            // 
            cmbmodule3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmodule3.FormattingEnabled = true;
            cmbmodule3.Items.AddRange(new object[] { "Programming Fundamentals", "Object Oriented Programming", "Database Systems", "Web Development", "Mobile Application Development", "Networking Fundamentals", "Operating Systems", "Software Project Management" });
            cmbmodule3.Location = new Point(226, 319);
            cmbmodule3.Margin = new Padding(5, 4, 5, 4);
            cmbmodule3.Name = "cmbmodule3";
            cmbmodule3.Size = new Size(798, 32);
            cmbmodule3.TabIndex = 4;
            // 
            // cmbmodule4
            // 
            cmbmodule4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbmodule4.FormattingEnabled = true;
            cmbmodule4.Items.AddRange(new object[] { "Programming Fundamentals", "Object Oriented Programming", "Database Systems", "Web Development", "Mobile Application Development", "Networking Fundamentals", "Operating Systems", "Software Project Management" });
            cmbmodule4.Location = new Point(226, 396);
            cmbmodule4.Margin = new Padding(5, 4, 5, 4);
            cmbmodule4.Name = "cmbmodule4";
            cmbmodule4.Size = new Size(798, 32);
            cmbmodule4.TabIndex = 5;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(41, 128, 185);
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(927, 692);
            btnsave.Margin = new Padding(5, 4, 5, 4);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(207, 69);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save Enrollment";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button3_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(64, 64, 64);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(66, 692);
            btnBack.Margin = new Padding(5, 4, 5, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(207, 69);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += lblExit_Click;
            // 
            // mycouses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 923);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "mycouses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Courses";
            Load += mycouses_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelCourseInfo.ResumeLayout(false);
            panelCourseInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ComboBox comdgree;
        private System.Windows.Forms.ComboBox cmbmodule1;
        private System.Windows.Forms.ComboBox cmbmodule2;
        private System.Windows.Forms.ComboBox cmbmodule3;
        private System.Windows.Forms.ComboBox cmbmodule4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panelCourseInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWelcome;
    }
}