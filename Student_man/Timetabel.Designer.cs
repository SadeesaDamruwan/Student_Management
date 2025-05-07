namespace Student_man
{
    partial class Timetabel
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
            timetablePanel = new TableLayoutPanel();
            panelTop = new Panel();
            lblTitle = new Label();
            panelButtons = new Panel();
            exportButton = new Button();
            printButton = new Button();
            panelFilter = new Panel();
            cbSelectView = new ComboBox();
            lblView = new Label();
            dateTimePicker = new DateTimePicker();
            lblWeek = new Label();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            sidePanel = new Panel();
            panelNextClasses = new FlowLayoutPanel();
            lblNextClasses = new Label();
            panelTop.SuspendLayout();
            panelButtons.SuspendLayout();
            panelFilter.SuspendLayout();
            statusStrip.SuspendLayout();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // timetablePanel
            // 
            timetablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timetablePanel.BackColor = Color.White;
            timetablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            timetablePanel.ColumnCount = 6;
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            timetablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            timetablePanel.Location = new Point(14, 153);
            timetablePanel.Margin = new Padding(4, 3, 4, 3);
            timetablePanel.Name = "timetablePanel";
            timetablePanel.RowCount = 10;
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            timetablePanel.Size = new Size(819, 677);
            timetablePanel.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(25, 118, 210);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 3, 4, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1136, 69);
            panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 14);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Timetable";
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelButtons.Controls.Add(exportButton);
            panelButtons.Controls.Add(printButton);
            panelButtons.Location = new Point(840, 153);
            panelButtons.Margin = new Padding(4, 3, 4, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(282, 48);
            panelButtons.TabIndex = 2;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(76, 175, 80);
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportButton.ForeColor = Color.White;
            exportButton.ImageAlign = ContentAlignment.MiddleLeft;
            exportButton.Location = new Point(142, 3);
            exportButton.Margin = new Padding(4, 3, 4, 3);
            exportButton.Name = "exportButton";
            exportButton.Padding = new Padding(6, 0, 0, 0);
            exportButton.Size = new Size(136, 40);
            exportButton.TabIndex = 1;
            exportButton.Text = "Exit";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // printButton
            // 
            printButton.BackColor = Color.FromArgb(33, 150, 243);
            printButton.FlatAppearance.BorderSize = 0;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printButton.ForeColor = Color.White;
            printButton.ImageAlign = ContentAlignment.MiddleLeft;
            printButton.Location = new Point(4, 3);
            printButton.Margin = new Padding(4, 3, 4, 3);
            printButton.Name = "printButton";
            printButton.Padding = new Padding(6, 0, 0, 0);
            printButton.Size = new Size(132, 40);
            printButton.TabIndex = 0;
            printButton.Text = "  Print";
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.WhiteSmoke;
            panelFilter.Controls.Add(cbSelectView);
            panelFilter.Controls.Add(lblView);
            panelFilter.Controls.Add(dateTimePicker);
            panelFilter.Controls.Add(lblWeek);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 69);
            panelFilter.Margin = new Padding(4, 3, 4, 3);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1136, 69);
            panelFilter.TabIndex = 3;
            // 
            // cbSelectView
            // 
            cbSelectView.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectView.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSelectView.FormattingEnabled = true;
            cbSelectView.Items.AddRange(new object[] { "Week View", "Day View", "List View" });
            cbSelectView.Location = new Point(467, 21);
            cbSelectView.Margin = new Padding(4, 3, 4, 3);
            cbSelectView.Name = "cbSelectView";
            cbSelectView.Size = new Size(174, 25);
            cbSelectView.TabIndex = 3;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblView.Location = new Point(415, 24);
            lblView.Margin = new Padding(4, 0, 4, 0);
            lblView.Name = "lblView";
            lblView.Size = new Size(39, 17);
            lblView.TabIndex = 2;
            lblView.Text = "View:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(117, 21);
            dateTimePicker.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(233, 25);
            dateTimePicker.TabIndex = 1;
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeek.Location = new Point(27, 24);
            lblWeek.Margin = new Padding(4, 0, 4, 0);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(78, 17);
            lblWeek.TabIndex = 0;
            lblWeek.Text = "Select Date:";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 845);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1136, 22);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(119, 17);
            statusLabel.Text = "Ready - Current Term";
            // 
            // sidePanel
            // 
            sidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sidePanel.BackColor = Color.WhiteSmoke;
            sidePanel.Controls.Add(panelNextClasses);
            sidePanel.Controls.Add(lblNextClasses);
            sidePanel.Location = new Point(840, 209);
            sidePanel.Margin = new Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(282, 622);
            sidePanel.TabIndex = 5;
            // 
            // panelNextClasses
            // 
            panelNextClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelNextClasses.AutoScroll = true;
            panelNextClasses.Location = new Point(4, 50);
            panelNextClasses.Margin = new Padding(4, 3, 4, 3);
            panelNextClasses.Name = "panelNextClasses";
            panelNextClasses.Padding = new Padding(6, 6, 6, 6);
            panelNextClasses.Size = new Size(275, 569);
            panelNextClasses.TabIndex = 1;
            // 
            // lblNextClasses
            // 
            lblNextClasses.BackColor = Color.FromArgb(66, 165, 245);
            lblNextClasses.Dock = DockStyle.Top;
            lblNextClasses.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNextClasses.ForeColor = Color.White;
            lblNextClasses.Location = new Point(0, 0);
            lblNextClasses.Margin = new Padding(4, 0, 4, 0);
            lblNextClasses.Name = "lblNextClasses";
            lblNextClasses.Padding = new Padding(12, 0, 0, 0);
            lblNextClasses.Size = new Size(282, 46);
            lblNextClasses.TabIndex = 0;
            lblNextClasses.Text = "Upcoming Classes";
            lblNextClasses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Timetabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1136, 867);
            Controls.Add(sidePanel);
            Controls.Add(statusStrip);
            Controls.Add(panelFilter);
            Controls.Add(panelButtons);
            Controls.Add(panelTop);
            Controls.Add(timetablePanel);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1152, 802);
            Name = "Timetabel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Timetable";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel timetablePanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cbSelectView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.FlowLayoutPanel panelNextClasses;
        private System.Windows.Forms.Label lblNextClasses;
    }
}