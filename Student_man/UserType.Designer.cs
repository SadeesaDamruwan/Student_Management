namespace Student_man
{
    partial class UserType
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
            btnuse = new Button();
            btnad = new Button();
            btnstaff = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(79, 75);
            label1.Name = "label1";
            label1.Size = new Size(153, 43);
            label1.TabIndex = 0;
            label1.Text = "Login ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnuse
            // 
            btnuse.BackColor = Color.White;
            btnuse.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnuse.ForeColor = Color.FromArgb(0, 117, 214);
            btnuse.Location = new Point(30, 189);
            btnuse.Margin = new Padding(3, 4, 3, 4);
            btnuse.Name = "btnuse";
            btnuse.Size = new Size(257, 64);
            btnuse.TabIndex = 1;
            btnuse.Text = "User";
            btnuse.UseVisualStyleBackColor = false;
            btnuse.Click += btnuse_Click;
            // 
            // btnad
            // 
            btnad.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnad.ForeColor = Color.FromArgb(0, 117, 214);
            btnad.Location = new Point(30, 304);
            btnad.Margin = new Padding(3, 4, 3, 4);
            btnad.Name = "btnad";
            btnad.Size = new Size(257, 64);
            btnad.TabIndex = 1;
            btnad.Text = "Lec";
            btnad.UseVisualStyleBackColor = true;
            btnad.Click += btnad_Click;
            // 
            // btnstaff
            // 
            btnstaff.Font = new Font("Bahnschrift SemiBold Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstaff.ForeColor = Color.FromArgb(0, 117, 214);
            btnstaff.Location = new Point(30, 416);
            btnstaff.Margin = new Padding(3, 4, 3, 4);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(257, 64);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Staff";
            btnstaff.UseVisualStyleBackColor = true;
            btnstaff.Click += btnstaff_Click;
            // 
            // UserType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 600);
            Controls.Add(btnstaff);
            Controls.Add(btnad);
            Controls.Add(btnuse);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserType";
            Load += UserType_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnuse;
        private Button btnad;
        private Button btnstaff;
    }
}