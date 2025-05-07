namespace Student_man
{
    partial class Reg
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            txtpasscon = new TextBox();
            btnReg = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(345, 33);
            label1.Name = "label1";
            label1.Size = new Size(293, 45);
            label1.TabIndex = 0;
            label1.Text = "Create an Account";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(443, 417);
            label2.Name = "label2";
            label2.Size = new Size(154, 19);
            label2.TabIndex = 1;
            label2.Text = "Already have account";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsername.Location = new Point(391, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(262, 22);
            txtUsername.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.White;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.FromArgb(64, 64, 64);
            txtpass.Location = new Point(391, 217);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '•';
            txtpass.Size = new Size(262, 22);
            txtpass.TabIndex = 3;
            // 
            // txtpasscon
            // 
            txtpasscon.BackColor = Color.White;
            txtpasscon.BorderStyle = BorderStyle.None;
            txtpasscon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasscon.ForeColor = Color.FromArgb(64, 64, 64);
            txtpasscon.Location = new Point(391, 291);
            txtpasscon.Name = "txtpasscon";
            txtpasscon.PasswordChar = '•';
            txtpasscon.Size = new Size(262, 22);
            txtpasscon.TabIndex = 4;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(41, 128, 185);
            btnReg.Cursor = Cursors.Hand;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(391, 354);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(262, 42);
            btnReg.TabIndex = 5;
            btnReg.Text = "REGISTER";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 497);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4cc88e8068fb873ea050ebc4e94eafed850f2409__2_;
            pictureBox1.Location = new Point(62, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 236);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 0;
            label3.Text = "STUDENT LMS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(388, 112);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 7;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(388, 186);
            label5.Name = "label5";
            label5.Size = new Size(73, 19);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(388, 260);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 9;
            label6.Text = "Confirm Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 128, 185);
            panel2.Location = new Point(391, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 1);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 128, 185);
            panel3.Location = new Point(391, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 1);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(41, 128, 185);
            panel4.Location = new Point(391, 316);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 1);
            panel4.TabIndex = 12;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 497);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnReg);
            Controls.Add(txtpasscon);
            Controls.Add(txtpass);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Reg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            Load += Reg_Load;
            Resize += Reg_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtpasscon;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}