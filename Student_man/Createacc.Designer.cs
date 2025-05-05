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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btncouse = new Button();
            btntime = new Button();
            button3 = new Button();
            lblExit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 47);
            label1.TabIndex = 0;
            label1.Text = "My WorkSpace";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(109, 35);
            label2.TabIndex = 0;
            label2.Text = "Welcome";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__2_1;
            pictureBox1.Location = new Point(29, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_1261718311_612x6121;
            pictureBox2.Location = new Point(29, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btncouse
            // 
            btncouse.BackColor = Color.FromArgb(0, 117, 214);
            btncouse.FlatStyle = FlatStyle.Flat;
            btncouse.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncouse.ForeColor = Color.White;
            btncouse.Location = new Point(122, 126);
            btncouse.Name = "btncouse";
            btncouse.Size = new Size(153, 40);
            btncouse.TabIndex = 2;
            btncouse.Text = "My Couses";
            btncouse.UseVisualStyleBackColor = false;
            btncouse.Click += btncouse_Click;
            // 
            // btntime
            // 
            btntime.BackColor = Color.FromArgb(0, 117, 214);
            btntime.FlatStyle = FlatStyle.Flat;
            btntime.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntime.ForeColor = Color.White;
            btntime.Location = new Point(122, 208);
            btntime.Name = "btntime";
            btntime.Size = new Size(153, 40);
            btntime.TabIndex = 2;
            btntime.Text = "My TimeTabel";
            btntime.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 117, 214);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(29, 381);
            button3.Name = "button3";
            button3.Size = new Size(246, 40);
            button3.TabIndex = 2;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // lblExit
            // 
            lblExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.ImeMode = ImeMode.NoControl;
            lblExit.Location = new Point(108, 424);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(83, 21);
            lblExit.TabIndex = 11;
            lblExit.Text = "Exit";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            // 
            // Createacc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 489);
            Controls.Add(lblExit);
            Controls.Add(button3);
            Controls.Add(btntime);
            Controls.Add(btncouse);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Createacc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Createacc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btncouse;
        private Button btntime;
        private Button button3;
        private Label lblExit;
    }
}