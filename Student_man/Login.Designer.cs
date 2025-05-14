namespace Student_man
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 123, 183);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4cc88e8068fb873ea050ebc4e94eafed850f2409__2_;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(31, 123, 183);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.Name = "txtUsername";
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtpass
            // 
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.Name = "txtpass";
            txtpass.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(31, 123, 183);
            label5.Name = "label5";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(31, 123, 183);
            button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.White;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(31, 123, 183);
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.FromArgb(31, 123, 183);
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Cursor = Cursors.Hand;
            label2.ForeColor = Color.FromArgb(31, 123, 183);
            label2.Name = "label2";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Cursor = Cursors.Hand;
            label3.ForeColor = Color.FromArgb(31, 123, 183);
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(txtpass);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtpass;
        private Label label5;
        private Button button3;
        private Button button1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}