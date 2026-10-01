namespace SASSAQueueManagementSystem
{
    partial class StaffDashboard
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
            lblCurrentDate = new Label();
            lblStaffRole = new Label();
            lblStaffName = new Label();
            lblSystemName = new Label();
            lblSystemSubtitle = new Label();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnQueueOverview = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            btnSearchByReferenceOrID = new Button();
            btnCallNext = new Button();
            btnSearch = new Button();
            btnQueueManagement = new Button();
            dgvStaffStatus = new DataGridView();
            ColQueueNumber = new DataGridViewTextBoxColumn();
            ColBeneficiaryName = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            lblCompleted = new Label();
            lblCompletedCount = new Label();
            panel4 = new Panel();
            lblServing = new Label();
            lblServingCount = new Label();
            panel3 = new Panel();
            lblWaiting = new Label();
            lblWaitingCount = new Label();
            panel2 = new Panel();
            lblBooked = new Label();
            lblBookedCount = new Label();
            lblDate = new Label();
            lblDashboardTitle = new Label();
            panel1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblCurrentDate);
            panel1.Controls.Add(lblStaffRole);
            panel1.Controls.Add(lblStaffName);
            panel1.Controls.Add(lblSystemName);
            panel1.Controls.Add(lblSystemSubtitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 49);
            panel1.TabIndex = 0;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Location = new Point(819, 26);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(31, 15);
            lblCurrentDate.TabIndex = 3;
            lblCurrentDate.Text = "Date";
            // 
            // lblStaffRole
            // 
            lblStaffRole.AutoSize = true;
            lblStaffRole.Location = new Point(886, 26);
            lblStaffRole.Name = "lblStaffRole";
            lblStaffRole.Size = new Size(83, 15);
            lblStaffRole.TabIndex = 2;
            lblStaffRole.Text = "Service Officer";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(886, 10);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(87, 15);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Officer Bhengu";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(3, 7);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(55, 20);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "SASSA";
            // 
            // lblSystemSubtitle
            // 
            lblSystemSubtitle.AutoSize = true;
            lblSystemSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemSubtitle.ForeColor = Color.White;
            lblSystemSubtitle.Location = new Point(3, 26);
            lblSystemSubtitle.Name = "lblSystemSubtitle";
            lblSystemSubtitle.Size = new Size(81, 15);
            lblSystemSubtitle.TabIndex = 2;
            lblSystemSubtitle.Text = "Staff Console";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(0, 51, 102);
            pnlSidebar.BorderStyle = BorderStyle.Fixed3D;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnQueueOverview);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 49);
            pnlSidebar.Margin = new Padding(3, 2, 3, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(166, 478);
            pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(25, 156);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(25, 114);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(115, 36);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnQueueOverview
            // 
            btnQueueOverview.Location = new Point(25, 72);
            btnQueueOverview.Name = "btnQueueOverview";
            btnQueueOverview.Size = new Size(115, 36);
            btnQueueOverview.TabIndex = 5;
            btnQueueOverview.Text = "Queue Overview";
            btnQueueOverview.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(25, 27);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(115, 36);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.Fixed3D;
            pnlMain.Controls.Add(btnSearchByReferenceOrID);
            pnlMain.Controls.Add(btnCallNext);
            pnlMain.Controls.Add(btnSearch);
            pnlMain.Controls.Add(btnQueueManagement);
            pnlMain.Controls.Add(dgvStaffStatus);
            pnlMain.Controls.Add(panel5);
            pnlMain.Controls.Add(panel4);
            pnlMain.Controls.Add(panel3);
            pnlMain.Controls.Add(panel2);
            pnlMain.Controls.Add(lblDate);
            pnlMain.Controls.Add(lblDashboardTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(166, 49);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(824, 478);
            pnlMain.TabIndex = 2;
            // 
            // btnSearchByReferenceOrID
            // 
            btnSearchByReferenceOrID.Location = new Point(473, 212);
            btnSearchByReferenceOrID.Name = "btnSearchByReferenceOrID";
            btnSearchByReferenceOrID.Size = new Size(174, 36);
            btnSearchByReferenceOrID.TabIndex = 14;
            btnSearchByReferenceOrID.Text = "Search by Reference or ID";
            btnSearchByReferenceOrID.UseVisualStyleBackColor = true;
            // 
            // btnCallNext
            // 
            btnCallNext.Location = new Point(107, 212);
            btnCallNext.Name = "btnCallNext";
            btnCallNext.Size = new Size(185, 36);
            btnCallNext.TabIndex = 13;
            btnCallNext.Text = "Call next, check in, completed";
            btnCallNext.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 51, 102);
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(429, 175);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(247, 100);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Bookings";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnQueueManagement
            // 
            btnQueueManagement.BackColor = Color.FromArgb(0, 51, 102);
            btnQueueManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQueueManagement.Location = new Point(74, 175);
            btnQueueManagement.Margin = new Padding(3, 2, 3, 2);
            btnQueueManagement.Name = "btnQueueManagement";
            btnQueueManagement.Size = new Size(247, 100);
            btnQueueManagement.TabIndex = 9;
            btnQueueManagement.Text = "Queue Management";
            btnQueueManagement.TextAlign = ContentAlignment.TopCenter;
            btnQueueManagement.UseVisualStyleBackColor = false;
            // 
            // dgvStaffStatus
            // 
            dgvStaffStatus.AllowUserToAddRows = false;
            dgvStaffStatus.AllowUserToDeleteRows = false;
            dgvStaffStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffStatus.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvStaffStatus.BorderStyle = BorderStyle.Fixed3D;
            dgvStaffStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffStatus.Columns.AddRange(new DataGridViewColumn[] { ColQueueNumber, ColBeneficiaryName, ColStatus });
            dgvStaffStatus.Location = new Point(44, 296);
            dgvStaffStatus.Margin = new Padding(3, 2, 3, 2);
            dgvStaffStatus.MultiSelect = false;
            dgvStaffStatus.Name = "dgvStaffStatus";
            dgvStaffStatus.ReadOnly = true;
            dgvStaffStatus.RowHeadersVisible = false;
            dgvStaffStatus.RowHeadersWidth = 51;
            dgvStaffStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffStatus.Size = new Size(682, 174);
            dgvStaffStatus.TabIndex = 8;
            // 
            // ColQueueNumber
            // 
            ColQueueNumber.HeaderText = "Queue No.";
            ColQueueNumber.MinimumWidth = 6;
            ColQueueNumber.Name = "ColQueueNumber";
            ColQueueNumber.ReadOnly = true;
            // 
            // ColBeneficiaryName
            // 
            ColBeneficiaryName.HeaderText = "Beneficiary Name";
            ColBeneficiaryName.MinimumWidth = 6;
            ColBeneficiaryName.Name = "ColBeneficiaryName";
            ColBeneficiaryName.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 6;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblCompleted);
            panel5.Controls.Add(lblCompletedCount);
            panel5.Location = new Point(595, 83);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(131, 75);
            panel5.TabIndex = 5;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(28, 40);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(66, 15);
            lblCompleted.TabIndex = 2;
            lblCompleted.Text = "Completed";
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.Location = new Point(56, 16);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(13, 15);
            lblCompletedCount.TabIndex = 1;
            lblCompletedCount.Text = "1";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lblServing);
            panel4.Controls.Add(lblServingCount);
            panel4.Location = new Point(405, 83);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(131, 75);
            panel4.TabIndex = 4;
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Location = new Point(36, 40);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(46, 15);
            lblServing.TabIndex = 2;
            lblServing.Text = "Serving";
            // 
            // lblServingCount
            // 
            lblServingCount.AutoSize = true;
            lblServingCount.Location = new Point(52, 16);
            lblServingCount.Name = "lblServingCount";
            lblServingCount.Size = new Size(13, 15);
            lblServingCount.TabIndex = 1;
            lblServingCount.Text = "1";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblWaiting);
            panel3.Controls.Add(lblWaitingCount);
            panel3.Location = new Point(214, 83);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(131, 75);
            panel3.TabIndex = 3;
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Location = new Point(28, 40);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(48, 15);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting";
            // 
            // lblWaitingCount
            // 
            lblWaitingCount.AutoSize = true;
            lblWaitingCount.Location = new Point(52, 16);
            lblWaitingCount.Name = "lblWaitingCount";
            lblWaitingCount.Size = new Size(13, 15);
            lblWaitingCount.TabIndex = 1;
            lblWaitingCount.Text = "1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblBooked);
            panel2.Controls.Add(lblBookedCount);
            panel2.Location = new Point(36, 83);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(131, 75);
            panel2.TabIndex = 2;
            // 
            // lblBooked
            // 
            lblBooked.AutoSize = true;
            lblBooked.Location = new Point(38, 40);
            lblBooked.Name = "lblBooked";
            lblBooked.Size = new Size(47, 15);
            lblBooked.TabIndex = 2;
            lblBooked.Text = "Booked";
            // 
            // lblBookedCount
            // 
            lblBookedCount.AutoSize = true;
            lblBookedCount.Location = new Point(58, 16);
            lblBookedCount.Name = "lblBookedCount";
            lblBookedCount.Size = new Size(13, 15);
            lblBookedCount.TabIndex = 1;
            lblBookedCount.Text = "6";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(18, 48);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(210, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Johannesburg CBD - Today's Overview";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(3, 8);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(263, 45);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Staff Dashboard";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(990, 527);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            Load += StaffDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSystemName;
        private Label lblSystemSubtitle;
        private Label lblStaffRole;
        private Label lblStaffName;
        private Panel pnlSidebar;
        private Panel pnlMain;
        private Label lblDashboardTitle;
        private Panel panel5;
        private Panel panel4;
        private Label lblServingCount;
        private Panel panel3;
        private Label lblWaiting;
        private Label lblWaitingCount;
        private Panel panel2;
        private Label lblBooked;
        private Label lblBookedCount;
        private Label lblDate;
        private Label lblCompleted;
        private Label lblCompletedCount;
        private Label lblServing;
        private DataGridView dgvStaffStatus;
        private DataGridViewTextBoxColumn ColQueueNumber;
        private DataGridViewTextBoxColumn ColBeneficiaryName;
        private DataGridViewTextBoxColumn ColStatus;
        private Button btnSearch;
        private Button btnQueueManagement;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnQueueOverview;
        private Button btnCallNext;
        private Button btnSearchByReferenceOrID;
        private Label lblCurrentDate;
    }
}