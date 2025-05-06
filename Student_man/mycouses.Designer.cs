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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            comdgree = new ComboBox();
            label4 = new Label();
            btnsave = new Button();
            lblExit = new Label();
            cmbmodule1 = new ComboBox();
            cmbmodule2 = new ComboBox();
            cmbmodule3 = new ComboBox();
            cmbmodule4 = new ComboBox();
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
            label1.TabIndex = 1;
            label1.Text = "My Couses";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(0, 91);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 3;
            label3.Text = "Dgree";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(0, 165);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 3;
            label2.Text = "Module1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(0, 260);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 3;
            label5.Text = "Module3";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(0, 213);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 3;
            label6.Text = "Module2";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comdgree
            // 
            comdgree.FormattingEnabled = true;
            comdgree.Items.AddRange(new object[] { "BSc (Hons) in Software Engineering", "BSc (Hons) in Computer Science" });
            comdgree.Location = new Point(120, 100);
            comdgree.Name = "comdgree";
            comdgree.Size = new Size(160, 23);
            comdgree.TabIndex = 4;
            comdgree.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(0, 308);
            label4.Name = "label4";
            label4.Size = new Size(114, 32);
            label4.TabIndex = 3;
            label4.Text = "Module4";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(0, 117, 214);
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Bahnschrift SemiBold SemiConden", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(22, 367);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(246, 40);
            btnsave.TabIndex = 6;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += button3_Click;
            // 
            // lblExit
            // 
            lblExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblExit.ForeColor = Color.FromArgb(0, 117, 214);
            lblExit.ImeMode = ImeMode.NoControl;
            lblExit.Location = new Point(97, 410);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(83, 21);
            lblExit.TabIndex = 11;
            lblExit.Text = "Go Back";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            // 
            // cmbmodule1
            // 
            cmbmodule1.FormattingEnabled = true;
            cmbmodule1.Items.AddRange(new object[] { "Introduction to Computer Science", "Mathematics for Computing" });
            cmbmodule1.Location = new Point(120, 174);
            cmbmodule1.Name = "cmbmodule1";
            cmbmodule1.Size = new Size(160, 23);
            cmbmodule1.TabIndex = 4;
            cmbmodule1.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // cmbmodule2
            // 
            cmbmodule2.FormattingEnabled = true;
            cmbmodule2.Items.AddRange(new object[] { "Programming in C#", "Computer Networks" });
            cmbmodule2.Location = new Point(120, 222);
            cmbmodule2.Name = "cmbmodule2";
            cmbmodule2.Size = new Size(160, 23);
            cmbmodule2.TabIndex = 4;
            cmbmodule2.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // cmbmodule3
            // 
            cmbmodule3.FormattingEnabled = true;
            cmbmodule3.Items.AddRange(new object[] { "Object Oriented Programming with Java", "Human-Computer Interaction\t" });
            cmbmodule3.Location = new Point(120, 269);
            cmbmodule3.Name = "cmbmodule3";
            cmbmodule3.Size = new Size(160, 23);
            cmbmodule3.TabIndex = 4;
            cmbmodule3.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // cmbmodule4
            // 
            cmbmodule4.FormattingEnabled = true;
            cmbmodule4.Items.AddRange(new object[] { "Algorithms and Complexity", "Web Based Application Development" });
            cmbmodule4.Location = new Point(120, 318);
            cmbmodule4.Name = "cmbmodule4";
            cmbmodule4.Size = new Size(160, 23);
            cmbmodule4.TabIndex = 4;
            cmbmodule4.SelectedIndexChanged += comdgree_SelectedIndexChanged;
            // 
            // mycouses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 450);
            Controls.Add(lblExit);
            Controls.Add(btnsave);
            Controls.Add(cmbmodule4);
            Controls.Add(cmbmodule3);
            Controls.Add(cmbmodule2);
            Controls.Add(cmbmodule1);
            Controls.Add(comdgree);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mycouses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mycouses";
            Load += mycouses_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private ComboBox comdgree;
        private Label label4;
        private Button btnsave;
        private Label lblExit;
        private ComboBox cmbmodule1;
        private ComboBox cmbmodule2;
        private ComboBox cmbmodule3;
        private ComboBox cmbmodule4;
    }
}