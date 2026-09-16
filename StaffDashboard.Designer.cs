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
            lblStaffRole = new Label();
            lblStaffName = new Label();
            lblSystemName = new Label();
            lblSystemSubtitle = new Label();
            pnlSidebar = new Panel();
            lblSignOut = new Label();
            lblProfile = new Label();
            lblQueueOverview = new Label();
            lblDashboard = new Label();
            pnlMain = new Panel();
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
            dgvStaffStatus = new DataGridView();
            ColQueueNumber = new DataGridViewTextBoxColumn();
            ColBeneficiaryName = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            btnQueueManagement = new Button();
            btnSearch = new Button();
            lblQueue = new Label();
            lblSearch = new Label();
            panel1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 91, 187);
            panel1.Controls.Add(lblStaffRole);
            panel1.Controls.Add(lblStaffName);
            panel1.Controls.Add(lblSystemName);
            panel1.Controls.Add(lblSystemSubtitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 65);
            panel1.TabIndex = 0;
            // 
            // lblStaffRole
            // 
            lblStaffRole.AutoSize = true;
            lblStaffRole.Location = new Point(1012, 34);
            lblStaffRole.Name = "lblStaffRole";
            lblStaffRole.Size = new Size(105, 20);
            lblStaffRole.TabIndex = 2;
            lblStaffRole.Text = "Service Officer";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(1012, 13);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(108, 20);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Officer Bhengu";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(3, 9);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(68, 25);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "SASSA";
            // 
            // lblSystemSubtitle
            // 
            lblSystemSubtitle.AutoSize = true;
            lblSystemSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemSubtitle.ForeColor = Color.White;
            lblSystemSubtitle.Location = new Point(3, 34);
            lblSystemSubtitle.Name = "lblSystemSubtitle";
            lblSystemSubtitle.Size = new Size(102, 20);
            lblSystemSubtitle.TabIndex = 2;
            lblSystemSubtitle.Text = "Staff Console";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(234, 242, 248);
            pnlSidebar.Controls.Add(lblSignOut);
            pnlSidebar.Controls.Add(lblProfile);
            pnlSidebar.Controls.Add(lblQueueOverview);
            pnlSidebar.Controls.Add(lblDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 65);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(190, 638);
            pnlSidebar.TabIndex = 1;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Location = new Point(39, 200);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(66, 20);
            lblSignOut.TabIndex = 3;
            lblSignOut.Text = "Sign Out";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(39, 148);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 20);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "Profile";
            // 
            // lblQueueOverview
            // 
            lblQueueOverview.AutoSize = true;
            lblQueueOverview.Location = new Point(39, 92);
            lblQueueOverview.Name = "lblQueueOverview";
            lblQueueOverview.Size = new Size(117, 20);
            lblQueueOverview.TabIndex = 1;
            lblQueueOverview.Text = "Queue Overview";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(39, 37);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(82, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblSearch);
            pnlMain.Controls.Add(lblQueue);
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
            pnlMain.Location = new Point(190, 65);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(942, 638);
            pnlMain.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblCompleted);
            panel5.Controls.Add(lblCompletedCount);
            panel5.Location = new Point(680, 111);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 100);
            panel5.TabIndex = 5;
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(32, 54);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(83, 20);
            lblCompleted.TabIndex = 2;
            lblCompleted.Text = "Completed";
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.Location = new Point(64, 21);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(17, 20);
            lblCompletedCount.TabIndex = 1;
            lblCompletedCount.Text = "1";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblServing);
            panel4.Controls.Add(lblServingCount);
            panel4.Location = new Point(463, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 100);
            panel4.TabIndex = 4;
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Location = new Point(41, 54);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(58, 20);
            lblServing.TabIndex = 2;
            lblServing.Text = "Serving";
            // 
            // lblServingCount
            // 
            lblServingCount.AutoSize = true;
            lblServingCount.Location = new Point(59, 21);
            lblServingCount.Name = "lblServingCount";
            lblServingCount.Size = new Size(17, 20);
            lblServingCount.TabIndex = 1;
            lblServingCount.Text = "1";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblWaiting);
            panel3.Controls.Add(lblWaitingCount);
            panel3.Location = new Point(244, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 100);
            panel3.TabIndex = 3;
            // 
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Location = new Point(32, 54);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(60, 20);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting";
            // 
            // lblWaitingCount
            // 
            lblWaitingCount.AutoSize = true;
            lblWaitingCount.Location = new Point(60, 21);
            lblWaitingCount.Name = "lblWaitingCount";
            lblWaitingCount.Size = new Size(17, 20);
            lblWaitingCount.TabIndex = 1;
            lblWaitingCount.Text = "1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblBooked);
            panel2.Controls.Add(lblBookedCount);
            panel2.Location = new Point(41, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 100);
            panel2.TabIndex = 2;
            // 
            // lblBooked
            // 
            lblBooked.AutoSize = true;
            lblBooked.Location = new Point(44, 54);
            lblBooked.Name = "lblBooked";
            lblBooked.Size = new Size(60, 20);
            lblBooked.TabIndex = 2;
            lblBooked.Text = "Booked";
            // 
            // lblBookedCount
            // 
            lblBookedCount.AutoSize = true;
            lblBookedCount.Location = new Point(66, 21);
            lblBookedCount.Name = "lblBookedCount";
            lblBookedCount.Size = new Size(17, 20);
            lblBookedCount.TabIndex = 1;
            lblBookedCount.Text = "6";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 64);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(261, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Johannesburg CBD - Today's Overview";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(3, 10);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(329, 54);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Staff Dashboard";
            // 
            // dgvStaffStatus
            // 
            dgvStaffStatus.AllowUserToAddRows = false;
            dgvStaffStatus.AllowUserToDeleteRows = false;
            dgvStaffStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffStatus.BackgroundColor = Color.White;
            dgvStaffStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffStatus.Columns.AddRange(new DataGridViewColumn[] { ColQueueNumber, ColBeneficiaryName, ColStatus });
            dgvStaffStatus.Location = new Point(50, 394);
            dgvStaffStatus.MultiSelect = false;
            dgvStaffStatus.Name = "dgvStaffStatus";
            dgvStaffStatus.ReadOnly = true;
            dgvStaffStatus.RowHeadersVisible = false;
            dgvStaffStatus.RowHeadersWidth = 51;
            dgvStaffStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaffStatus.Size = new Size(780, 232);
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
            // btnQueueManagement
            // 
            btnQueueManagement.BackColor = Color.FromArgb(0, 91, 187);
            btnQueueManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQueueManagement.Location = new Point(85, 233);
            btnQueueManagement.Name = "btnQueueManagement";
            btnQueueManagement.Size = new Size(282, 134);
            btnQueueManagement.TabIndex = 9;
            btnQueueManagement.Text = "Queue Management";
            btnQueueManagement.TextAlign = ContentAlignment.TopCenter;
            btnQueueManagement.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(504, 233);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(282, 134);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search Bookings";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.BackColor = Color.FromArgb(0, 91, 187);
            lblQueue.Location = new Point(115, 286);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(205, 20);
            lblQueue.TabIndex = 11;
            lblQueue.Text = "Call next, check in, completed";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.White;
            lblSearch.Location = new Point(528, 284);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(176, 20);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search by reference or ID";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1132, 703);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(panel1);
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaffStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSystemName;
        private Label lblSystemSubtitle;
        private Label lblStaffRole;
        private Label lblStaffName;
        private Panel pnlSidebar;
        private Label lblSignOut;
        private Label lblProfile;
        private Label lblQueueOverview;
        private Label lblDashboard;
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
        private Label lblQueue;
        private Button btnSearch;
        private Button btnQueueManagement;
        private Label lblSearch;
    }
}