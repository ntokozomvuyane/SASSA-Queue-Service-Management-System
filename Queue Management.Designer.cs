namespace SASSAQueueManagementSystem
{
    partial class frmQueueManagementSystem
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
            pnlHeader = new Panel();
            btnSignOut = new Button();
            lblServiceOfficer = new Label();
            lblOfficer = new Label();
            lblStaffConsole = new Label();
            lblSassa = new Label();
            lblQueueManagement = new Label();
            pnlButtons = new Panel();
            Searchbtn = new Button();
            Queuebtn = new Button();
            Dashboardbtn = new Button();
            dgvQueueManagement = new DataGridView();
            booked = new DataGridViewTextBoxColumn();
            noShow = new DataGridViewTextBoxColumn();
            checkedIn = new DataGridViewTextBoxColumn();
            waiting = new DataGridViewTextBoxColumn();
            beingServed = new DataGridViewTextBoxColumn();
            completed = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueueManagement).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Controls.Add(btnSignOut);
            pnlHeader.Controls.Add(lblServiceOfficer);
            pnlHeader.Controls.Add(lblOfficer);
            pnlHeader.Controls.Add(lblStaffConsole);
            pnlHeader.Controls.Add(lblSassa);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(781, 53);
            pnlHeader.TabIndex = 0;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.SteelBlue;
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(713, 12);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(75, 23);
            btnSignOut.TabIndex = 5;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // lblServiceOfficer
            // 
            lblServiceOfficer.AutoSize = true;
            lblServiceOfficer.ForeColor = Color.White;
            lblServiceOfficer.Location = new Point(594, 24);
            lblServiceOfficer.Name = "lblServiceOfficer";
            lblServiceOfficer.Size = new Size(83, 15);
            lblServiceOfficer.TabIndex = 4;
            lblServiceOfficer.Text = "Service Officer";
            // 
            // lblOfficer
            // 
            lblOfficer.AutoSize = true;
            lblOfficer.ForeColor = Color.White;
            lblOfficer.Location = new Point(594, 9);
            lblOfficer.Name = "lblOfficer";
            lblOfficer.Size = new Size(87, 15);
            lblOfficer.TabIndex = 3;
            lblOfficer.Text = "Officer Bhengu";
            // 
            // lblStaffConsole
            // 
            lblStaffConsole.AutoSize = true;
            lblStaffConsole.ForeColor = Color.White;
            lblStaffConsole.Location = new Point(12, 24);
            lblStaffConsole.Name = "lblStaffConsole";
            lblStaffConsole.Size = new Size(77, 15);
            lblStaffConsole.TabIndex = 1;
            lblStaffConsole.Text = "Staff Console";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(12, 9);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(41, 15);
            lblSassa.TabIndex = 0;
            lblSassa.Text = "SASSA";
            // 
            // lblQueueManagement
            // 
            lblQueueManagement.AutoSize = true;
            lblQueueManagement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueueManagement.Location = new Point(20, 60);
            lblQueueManagement.Name = "lblQueueManagement";
            lblQueueManagement.Size = new Size(193, 25);
            lblQueueManagement.TabIndex = 1;
            lblQueueManagement.Text = "Queue Management";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(Searchbtn);
            pnlButtons.Controls.Add(Queuebtn);
            pnlButtons.Controls.Add(Dashboardbtn);
            pnlButtons.Location = new Point(2, 534);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(778, 37);
            pnlButtons.TabIndex = 3;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(662, 5);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 26);
            Searchbtn.TabIndex = 2;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            // 
            // Queuebtn
            // 
            Queuebtn.ForeColor = Color.DarkBlue;
            Queuebtn.Location = new Point(370, 5);
            Queuebtn.Name = "Queuebtn";
            Queuebtn.Size = new Size(75, 23);
            Queuebtn.TabIndex = 1;
            Queuebtn.Text = "Queue";
            Queuebtn.UseVisualStyleBackColor = true;
            // 
            // Dashboardbtn
            // 
            Dashboardbtn.ForeColor = Color.Gray;
            Dashboardbtn.Location = new Point(36, 5);
            Dashboardbtn.Name = "Dashboardbtn";
            Dashboardbtn.Size = new Size(84, 25);
            Dashboardbtn.TabIndex = 0;
            Dashboardbtn.Text = "Dashboard";
            Dashboardbtn.UseVisualStyleBackColor = true;
            // 
            // dgvQueueManagement
            // 
            dgvQueueManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueueManagement.Columns.AddRange(new DataGridViewColumn[] { booked, noShow, checkedIn, waiting, beingServed, completed });
            dgvQueueManagement.Location = new Point(20, 101);
            dgvQueueManagement.Margin = new Padding(2, 2, 2, 2);
            dgvQueueManagement.Name = "dgvQueueManagement";
            dgvQueueManagement.RowHeadersWidth = 51;
            dgvQueueManagement.Size = new Size(624, 337);
            dgvQueueManagement.TabIndex = 4;
            // 
            // booked
            // 
            booked.HeaderText = "Booked";
            booked.MinimumWidth = 6;
            booked.Name = "booked";
            booked.Width = 125;
            // 
            // noShow
            // 
            noShow.HeaderText = "No Show";
            noShow.MinimumWidth = 6;
            noShow.Name = "noShow";
            noShow.Width = 125;
            // 
            // checkedIn
            // 
            checkedIn.HeaderText = "Checked In";
            checkedIn.MinimumWidth = 6;
            checkedIn.Name = "checkedIn";
            checkedIn.Width = 125;
            // 
            // waiting
            // 
            waiting.HeaderText = "Waiting";
            waiting.MinimumWidth = 6;
            waiting.Name = "waiting";
            waiting.Width = 125;
            // 
            // beingServed
            // 
            beingServed.HeaderText = "Being Served";
            beingServed.MinimumWidth = 6;
            beingServed.Name = "beingServed";
            beingServed.Width = 125;
            // 
            // completed
            // 
            completed.HeaderText = "Completed";
            completed.MinimumWidth = 6;
            completed.Name = "completed";
            completed.Width = 125;
            // 
            // frmQueueManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(798, 488);
            Controls.Add(dgvQueueManagement);
            Controls.Add(pnlButtons);
            Controls.Add(lblQueueManagement);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmQueueManagementSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queue Management System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQueueManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label24;
        private Button button9;
        private Button button10;
        private Panel pnlHeader;
        private Label lblSassa;
        private Label lblStaffConsole;
        private Label lblServiceOfficer;
        private Label lblOfficer;
        private Button btnSignOut;
        private Label lblQueueManagement;
        private Panel pnlButtons;
        private Button Searchbtn;
        private Button Queuebtn;
        private Button Dashboardbtn;
        private DataGridView dgvQueueManagement;
        private DataGridViewTextBoxColumn booked;
        private DataGridViewTextBoxColumn noShow;
        private DataGridViewTextBoxColumn checkedIn;
        private DataGridViewTextBoxColumn waiting;
        private DataGridViewTextBoxColumn beingServed;
        private DataGridViewTextBoxColumn completed;
    }
}
