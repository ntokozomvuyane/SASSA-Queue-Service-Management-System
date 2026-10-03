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
            pnlHeader = new Panel();
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
            pnlContent = new Panel();
            pnlDashboardHome = new Panel();
            lblDashboardTitle = new Label();
            lblDate = new Label();
            btnSearch = new Button();
            dgvStaffStatus = new DataGridView();
            ColQueueNumber = new DataGridViewTextBoxColumn();
            ColBeneficiaryName = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            pnlBooked = new Panel();
            lblBooked = new Label();
            lblBookedCount = new Label();
            pnlWait = new Panel();
            lblWaiting = new Label();
            lblWaitingCount = new Label();
            pnlCompleted = new Panel();
            lblCompleted = new Label();
            lblCompletedCount = new Label();
            pnlServing = new Panel();
            lblServing = new Label();
            lblServingCount = new Label();
            btnQueueManagement = new Button();
            pnlCheckedIn = new Panel();
            lblCheckedIn = new Label();
            lblCheckedInCount = new Label();
            pnlNoShow = new Panel();
            lblNoShow = new Label();
            lblNoShowCount = new Label();
            lnklblCallNext = new LinkLabel();
            lnklblSearchByReferenceorID = new LinkLabel();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlDashboardHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).BeginInit();
            pnlBooked.SuspendLayout();
            pnlWait.SuspendLayout();
            pnlCompleted.SuspendLayout();
            pnlServing.SuspendLayout();
            pnlCheckedIn.SuspendLayout();
            pnlNoShow.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 51, 102);
            pnlHeader.BorderStyle = BorderStyle.Fixed3D;
            pnlHeader.Controls.Add(lblCurrentDate);
            pnlHeader.Controls.Add(lblStaffRole);
            pnlHeader.Controls.Add(lblStaffName);
            pnlHeader.Controls.Add(lblSystemName);
            pnlHeader.Controls.Add(lblSystemSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(990, 49);
            pnlHeader.TabIndex = 0;
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
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(25, 114);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(115, 36);
            btnProfile.TabIndex = 6;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnQueueOverview
            // 
            btnQueueOverview.Location = new Point(25, 72);
            btnQueueOverview.Name = "btnQueueOverview";
            btnQueueOverview.Size = new Size(115, 36);
            btnQueueOverview.TabIndex = 5;
            btnQueueOverview.Text = "Queue Overview";
            btnQueueOverview.UseVisualStyleBackColor = true;
            btnQueueOverview.Click += btnQueueOverview_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(25, 27);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(115, 36);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlContent
            // 
            pnlContent.BorderStyle = BorderStyle.Fixed3D;
            pnlContent.Controls.Add(pnlDashboardHome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(166, 49);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(824, 478);
            pnlContent.TabIndex = 2;
            // 
            // pnlDashboardHome
            // 
            pnlDashboardHome.Controls.Add(lnklblSearchByReferenceorID);
            pnlDashboardHome.Controls.Add(lnklblCallNext);
            pnlDashboardHome.Controls.Add(pnlNoShow);
            pnlDashboardHome.Controls.Add(pnlCheckedIn);
            pnlDashboardHome.Controls.Add(lblDashboardTitle);
            pnlDashboardHome.Controls.Add(lblDate);
            pnlDashboardHome.Controls.Add(btnSearch);
            pnlDashboardHome.Controls.Add(dgvStaffStatus);
            pnlDashboardHome.Controls.Add(pnlBooked);
            pnlDashboardHome.Controls.Add(pnlWait);
            pnlDashboardHome.Controls.Add(pnlCompleted);
            pnlDashboardHome.Controls.Add(pnlServing);
            pnlDashboardHome.Controls.Add(btnQueueManagement);
            pnlDashboardHome.Dock = DockStyle.Fill;
            pnlDashboardHome.Location = new Point(0, 0);
            pnlDashboardHome.Name = "pnlDashboardHome";
            pnlDashboardHome.Size = new Size(820, 474);
            pnlDashboardHome.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(15, 14);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(263, 45);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Staff Dashboard";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(29, 59);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(210, 15);
            lblDate.TabIndex = 1;
            lblDate.Text = "Johannesburg CBD - Today's Overview";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 51, 102);
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(427, 195);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(227, 104);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Bookings";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = false;
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
            dgvStaffStatus.Location = new Point(29, 333);
            dgvStaffStatus.Margin = new Padding(3, 2, 3, 2);
            dgvStaffStatus.MultiSelect = false;
            dgvStaffStatus.Name = "dgvStaffStatus";
            dgvStaffStatus.ReadOnly = true;
            dgvStaffStatus.RowHeadersVisible = false;
            dgvStaffStatus.RowHeadersWidth = 51;
            dgvStaffStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffStatus.Size = new Size(655, 101);
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
            // pnlBooked
            // 
            pnlBooked.BorderStyle = BorderStyle.Fixed3D;
            pnlBooked.Controls.Add(lblBooked);
            pnlBooked.Controls.Add(lblBookedCount);
            pnlBooked.Location = new Point(4, 92);
            pnlBooked.Margin = new Padding(3, 2, 3, 2);
            pnlBooked.Name = "pnlBooked";
            pnlBooked.Size = new Size(106, 75);
            pnlBooked.TabIndex = 2;
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
            // pnlWait
            // 
            pnlWait.BorderStyle = BorderStyle.Fixed3D;
            pnlWait.Controls.Add(lblWaiting);
            pnlWait.Controls.Add(lblWaitingCount);
            pnlWait.Location = new Point(245, 92);
            pnlWait.Margin = new Padding(3, 2, 3, 2);
            pnlWait.Name = "pnlWait";
            pnlWait.Size = new Size(113, 75);
            pnlWait.TabIndex = 3;
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
            // pnlCompleted
            // 
            pnlCompleted.BorderStyle = BorderStyle.Fixed3D;
            pnlCompleted.Controls.Add(lblCompleted);
            pnlCompleted.Controls.Add(lblCompletedCount);
            pnlCompleted.Location = new Point(532, 92);
            pnlCompleted.Margin = new Padding(3, 2, 3, 2);
            pnlCompleted.Name = "pnlCompleted";
            pnlCompleted.Size = new Size(131, 75);
            pnlCompleted.TabIndex = 5;
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
            // pnlServing
            // 
            pnlServing.BorderStyle = BorderStyle.Fixed3D;
            pnlServing.Controls.Add(lblServing);
            pnlServing.Controls.Add(lblServingCount);
            pnlServing.Location = new Point(388, 92);
            pnlServing.Margin = new Padding(3, 2, 3, 2);
            pnlServing.Name = "pnlServing";
            pnlServing.Size = new Size(124, 75);
            pnlServing.TabIndex = 4;
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
            // btnQueueManagement
            // 
            btnQueueManagement.BackColor = Color.FromArgb(0, 51, 102);
            btnQueueManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQueueManagement.Location = new Point(77, 195);
            btnQueueManagement.Margin = new Padding(3, 2, 3, 2);
            btnQueueManagement.Name = "btnQueueManagement";
            btnQueueManagement.Size = new Size(246, 104);
            btnQueueManagement.TabIndex = 9;
            btnQueueManagement.Text = "Queue Management";
            btnQueueManagement.TextAlign = ContentAlignment.TopCenter;
            btnQueueManagement.UseVisualStyleBackColor = false;
            // 
            // pnlCheckedIn
            // 
            pnlCheckedIn.BorderStyle = BorderStyle.Fixed3D;
            pnlCheckedIn.Controls.Add(lblCheckedIn);
            pnlCheckedIn.Controls.Add(lblCheckedInCount);
            pnlCheckedIn.Location = new Point(116, 92);
            pnlCheckedIn.Margin = new Padding(3, 2, 3, 2);
            pnlCheckedIn.Name = "pnlCheckedIn";
            pnlCheckedIn.Size = new Size(110, 75);
            pnlCheckedIn.TabIndex = 15;
            // 
            // lblCheckedIn
            // 
            lblCheckedIn.AutoSize = true;
            lblCheckedIn.Location = new Point(28, 40);
            lblCheckedIn.Name = "lblCheckedIn";
            lblCheckedIn.Size = new Size(66, 15);
            lblCheckedIn.TabIndex = 2;
            lblCheckedIn.Text = "Checked In";
            // 
            // lblCheckedInCount
            // 
            lblCheckedInCount.AutoSize = true;
            lblCheckedInCount.Location = new Point(52, 16);
            lblCheckedInCount.Name = "lblCheckedInCount";
            lblCheckedInCount.Size = new Size(13, 15);
            lblCheckedInCount.TabIndex = 1;
            lblCheckedInCount.Text = "1";
            // 
            // pnlNoShow
            // 
            pnlNoShow.BorderStyle = BorderStyle.Fixed3D;
            pnlNoShow.Controls.Add(lblNoShow);
            pnlNoShow.Controls.Add(lblNoShowCount);
            pnlNoShow.Location = new Point(686, 92);
            pnlNoShow.Margin = new Padding(3, 2, 3, 2);
            pnlNoShow.Name = "pnlNoShow";
            pnlNoShow.Size = new Size(124, 75);
            pnlNoShow.TabIndex = 16;
            // 
            // lblNoShow
            // 
            lblNoShow.AutoSize = true;
            lblNoShow.Location = new Point(36, 40);
            lblNoShow.Name = "lblNoShow";
            lblNoShow.Size = new Size(57, 15);
            lblNoShow.TabIndex = 2;
            lblNoShow.Text = "No-Show";
            // 
            // lblNoShowCount
            // 
            lblNoShowCount.AutoSize = true;
            lblNoShowCount.Location = new Point(52, 16);
            lblNoShowCount.Name = "lblNoShowCount";
            lblNoShowCount.Size = new Size(13, 15);
            lblNoShowCount.TabIndex = 1;
            lblNoShowCount.Text = "1";
            // 
            // lnklblCallNext
            // 
            lnklblCallNext.AutoSize = true;
            lnklblCallNext.Location = new Point(136, 234);
            lnklblCallNext.Name = "lnklblCallNext";
            lnklblCallNext.Size = new Size(165, 15);
            lnklblCallNext.TabIndex = 17;
            lnklblCallNext.TabStop = true;
            lnklblCallNext.Text = "Call next, check in, completed";
            // 
            // lnklblSearchByReferenceorID
            // 
            lnklblSearchByReferenceorID.AutoSize = true;
            lnklblSearchByReferenceorID.Location = new Point(498, 234);
            lnklblSearchByReferenceorID.Name = "lnklblSearchByReferenceorID";
            lnklblSearchByReferenceorID.Size = new Size(141, 15);
            lnklblSearchByReferenceorID.TabIndex = 18;
            lnklblSearchByReferenceorID.TabStop = true;
            lnklblSearchByReferenceorID.Text = "Search by Reference or ID";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(990, 527);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            Load += StaffDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlDashboardHome.ResumeLayout(false);
            pnlDashboardHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).EndInit();
            pnlBooked.ResumeLayout(false);
            pnlBooked.PerformLayout();
            pnlWait.ResumeLayout(false);
            pnlWait.PerformLayout();
            pnlCompleted.ResumeLayout(false);
            pnlCompleted.PerformLayout();
            pnlServing.ResumeLayout(false);
            pnlServing.PerformLayout();
            pnlCheckedIn.ResumeLayout(false);
            pnlCheckedIn.PerformLayout();
            pnlNoShow.ResumeLayout(false);
            pnlNoShow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSystemName;
        private Label lblSystemSubtitle;
        private Label lblStaffRole;
        private Label lblStaffName;
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Label lblDashboardTitle;
        private Panel pnlCompleted;
        private Panel pnlServing;
        private Label lblServingCount;
        private Panel pnlWait;
        private Label lblWaiting;
        private Label lblWaitingCount;
        private Panel pnlBooked;
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
        private Label lblCurrentDate;
        private Panel pnlDashboardHome;
        private Panel pnlNoShow;
        private Label lblNoShow;
        private Label lblNoShowCount;
        private Panel pnlCheckedIn;
        private Label lblCheckedIn;
        private Label lblCheckedInCount;
        private LinkLabel lnklblSearchByReferenceorID;
        private LinkLabel lnklblCallNext;
    }
}