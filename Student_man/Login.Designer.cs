namespace Student_man
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnlog = new Button();
            label1 = new Label();
            lblclear = new Label();
            lblExit = new Label();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Paint += panel1_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.images;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images__1_;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4cc88e8068fb873ea050ebc4e94eafed850f2409__2_;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnlog
            // 
            btnlog.BackColor = Color.FromArgb(0, 117, 214);
            btnlog.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnlog, "btnlog");
            btnlog.Name = "btnlog";
            btnlog.UseVisualStyleBackColor = false;
            btnlog.Click += button3_Click;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // lblclear
            // 
            resources.ApplyResources(lblclear, "lblclear");
            lblclear.ForeColor = Color.FromArgb(0, 117, 214);
            lblclear.Name = "lblclear";
            lblclear.Click += label2_Click_1;
            // 
            // lblExit
            // 
            resources.ApplyResources(lblExit, "lblExit");
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.Name = "lblExit";
            lblExit.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.ForeColor = Color.FromArgb(0, 117, 214);
            txtUsername.Name = "txtUsername";
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.ForeColor = Color.FromArgb(0, 117, 214);
            txtpass.Name = "txtpass";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Name = "label4";
            label4.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(lblExit);
            Controls.Add(lblclear);
            Controls.Add(btnlog);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox4;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button btnlog;
        public Label label1;
        private Label lblclear;
        private Label lblExit;
        private TextBox txtUsername;
        private TextBox txtpass;
        private Label label4;
        private Button button1;
    }
}
