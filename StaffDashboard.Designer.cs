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
            lblSystemName = new Label();
            lblSystemSubtitle = new Label();
            lblStaffName = new Label();
            lblStaffRole = new Label();
            pnlSidebar = new Panel();
            lblDashboard = new Label();
            lblQueueOverview = new Label();
            lblProfile = new Label();
            lblSignOut = new Label();
            pnlMain = new Panel();
            lblDashboardTitle = new Label();
            lblDate = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            lblBookedCount = new Label();
            lblBooked = new Label();
            lblWaitingCount = new Label();
            lblWaiting = new Label();
            lblServingCount = new Label();
            lblServing = new Label();
            lblCompletedCount = new Label();
            lblCompleted = new Label();
            pnlQueueManagement = new Panel();
            lblQueueTitle = new Label();
            lblQueueDescription = new Label();
            pnlSearchBookings = new Panel();
            lblSearchTitle = new Label();
            lblSearchDescription = new Label();
            pnlTodaysQueue = new Panel();
            lblQueueHeading = new Label();
            lblQueueCount1 = new Label();
            lblQueueCount2 = new Label();
            lblQueueCount3 = new Label();
            lblQueueName1 = new Label();
            lblQueueName2 = new Label();
            lblQueueName3 = new Label();
            lblQueueWaiting = new Label();
            lblQueueServed = new Label();
            lblQueueCheckedIn = new Label();
            panel1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlQueueManagement.SuspendLayout();
            pnlSearchBookings.SuspendLayout();
            pnlTodaysQueue.SuspendLayout();
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
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(1012, 13);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(108, 20);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Officer Bhengu";
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
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(39, 37);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(82, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
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
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(39, 148);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 20);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "Profile";
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
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlTodaysQueue);
            pnlMain.Controls.Add(pnlSearchBookings);
            pnlMain.Controls.Add(pnlQueueManagement);
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
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 64);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(261, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Johannesburg CBD - Today's Overview";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblBooked);
            panel2.Controls.Add(lblBookedCount);
            panel2.Location = new Point(41, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 100);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblWaiting);
            panel3.Controls.Add(lblWaitingCount);
            panel3.Location = new Point(255, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 100);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblServing);
            panel4.Controls.Add(lblServingCount);
            panel4.Location = new Point(470, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 100);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblCompleted);
            panel5.Controls.Add(lblCompletedCount);
            panel5.Location = new Point(689, 137);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 100);
            panel5.TabIndex = 5;
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
            // lblBooked
            // 
            lblBooked.AutoSize = true;
            lblBooked.Location = new Point(44, 54);
            lblBooked.Name = "lblBooked";
            lblBooked.Size = new Size(60, 20);
            lblBooked.TabIndex = 2;
            lblBooked.Text = "Booked";
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
            // lblWaiting
            // 
            lblWaiting.AutoSize = true;
            lblWaiting.Location = new Point(32, 54);
            lblWaiting.Name = "lblWaiting";
            lblWaiting.Size = new Size(60, 20);
            lblWaiting.TabIndex = 2;
            lblWaiting.Text = "Waiting";
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
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Location = new Point(41, 54);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(58, 20);
            lblServing.TabIndex = 2;
            lblServing.Text = "Serving";
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
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(32, 54);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(83, 20);
            lblCompleted.TabIndex = 2;
            lblCompleted.Text = "Completed";
            // 
            // pnlQueueManagement
            // 
            pnlQueueManagement.BackColor = Color.FromArgb(0, 91, 187);
            pnlQueueManagement.Controls.Add(lblQueueDescription);
            pnlQueueManagement.Controls.Add(lblQueueTitle);
            pnlQueueManagement.Location = new Point(82, 271);
            pnlQueueManagement.Name = "pnlQueueManagement";
            pnlQueueManagement.Size = new Size(250, 125);
            pnlQueueManagement.TabIndex = 6;
            // 
            // lblQueueTitle
            // 
            lblQueueTitle.AutoSize = true;
            lblQueueTitle.ForeColor = Color.White;
            lblQueueTitle.Location = new Point(3, 9);
            lblQueueTitle.Name = "lblQueueTitle";
            lblQueueTitle.Size = new Size(144, 20);
            lblQueueTitle.TabIndex = 7;
            lblQueueTitle.Text = "Queue Management";
            // 
            // lblQueueDescription
            // 
            lblQueueDescription.AutoSize = true;
            lblQueueDescription.BackColor = Color.FromArgb(0, 91, 187);
            lblQueueDescription.ForeColor = Color.White;
            lblQueueDescription.Location = new Point(3, 39);
            lblQueueDescription.Name = "lblQueueDescription";
            lblQueueDescription.Size = new Size(196, 20);
            lblQueueDescription.TabIndex = 8;
            lblQueueDescription.Text = "Call next, check in, complete";
            // 
            // pnlSearchBookings
            // 
            pnlSearchBookings.Controls.Add(lblSearchDescription);
            pnlSearchBookings.Controls.Add(lblSearchTitle);
            pnlSearchBookings.Location = new Point(520, 271);
            pnlSearchBookings.Name = "pnlSearchBookings";
            pnlSearchBookings.Size = new Size(250, 125);
            pnlSearchBookings.TabIndex = 7;
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Location = new Point(12, 9);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(118, 20);
            lblSearchTitle.TabIndex = 8;
            lblSearchTitle.Text = "Search Bookings";
            // 
            // lblSearchDescription
            // 
            lblSearchDescription.AutoSize = true;
            lblSearchDescription.Location = new Point(12, 39);
            lblSearchDescription.Name = "lblSearchDescription";
            lblSearchDescription.Size = new Size(160, 20);
            lblSearchDescription.TabIndex = 9;
            lblSearchDescription.Text = "Find by reference or ID";
            // 
            // pnlTodaysQueue
            // 
            pnlTodaysQueue.Controls.Add(lblQueueCheckedIn);
            pnlTodaysQueue.Controls.Add(lblQueueServed);
            pnlTodaysQueue.Controls.Add(lblQueueWaiting);
            pnlTodaysQueue.Controls.Add(lblQueueName3);
            pnlTodaysQueue.Controls.Add(lblQueueName2);
            pnlTodaysQueue.Controls.Add(lblQueueName1);
            pnlTodaysQueue.Controls.Add(lblQueueCount3);
            pnlTodaysQueue.Controls.Add(lblQueueCount2);
            pnlTodaysQueue.Controls.Add(lblQueueCount1);
            pnlTodaysQueue.Controls.Add(lblQueueHeading);
            pnlTodaysQueue.Location = new Point(41, 420);
            pnlTodaysQueue.Name = "pnlTodaysQueue";
            pnlTodaysQueue.Size = new Size(798, 206);
            pnlTodaysQueue.TabIndex = 8;
            // 
            // lblQueueHeading
            // 
            lblQueueHeading.AutoSize = true;
            lblQueueHeading.Location = new Point(12, 13);
            lblQueueHeading.Name = "lblQueueHeading";
            lblQueueHeading.Size = new Size(105, 20);
            lblQueueHeading.TabIndex = 0;
            lblQueueHeading.Text = "Today's Queue";
            // 
            // lblQueueCount1
            // 
            lblQueueCount1.AutoSize = true;
            lblQueueCount1.Location = new Point(20, 51);
            lblQueueCount1.Name = "lblQueueCount1";
            lblQueueCount1.Size = new Size(17, 20);
            lblQueueCount1.TabIndex = 1;
            lblQueueCount1.Text = "3";
            // 
            // lblQueueCount2
            // 
            lblQueueCount2.AutoSize = true;
            lblQueueCount2.Location = new Point(20, 93);
            lblQueueCount2.Name = "lblQueueCount2";
            lblQueueCount2.Size = new Size(17, 20);
            lblQueueCount2.TabIndex = 2;
            lblQueueCount2.Text = "1";
            // 
            // lblQueueCount3
            // 
            lblQueueCount3.AutoSize = true;
            lblQueueCount3.Location = new Point(20, 136);
            lblQueueCount3.Name = "lblQueueCount3";
            lblQueueCount3.Size = new Size(17, 20);
            lblQueueCount3.TabIndex = 3;
            lblQueueCount3.Text = "4";
            // 
            // lblQueueName1
            // 
            lblQueueName1.AutoSize = true;
            lblQueueName1.Location = new Point(241, 51);
            lblQueueName1.Name = "lblQueueName1";
            lblQueueName1.Size = new Size(112, 20);
            lblQueueName1.TabIndex = 4;
            lblQueueName1.Text = "Nomsa Dlamini";
            // 
            // lblQueueName2
            // 
            lblQueueName2.AutoSize = true;
            lblQueueName2.Location = new Point(241, 93);
            lblQueueName2.Name = "lblQueueName2";
            lblQueueName2.Size = new Size(88, 20);
            lblQueueName2.TabIndex = 5;
            lblQueueName2.Text = "Sipho Nkosi";
            // 
            // lblQueueName3
            // 
            lblQueueName3.AutoSize = true;
            lblQueueName3.Location = new Point(241, 136);
            lblQueueName3.Name = "lblQueueName3";
            lblQueueName3.Size = new Size(98, 20);
            lblQueueName3.TabIndex = 6;
            lblQueueName3.Text = "Mpho Sithole";
            // 
            // lblQueueWaiting
            // 
            lblQueueWaiting.AutoSize = true;
            lblQueueWaiting.Location = new Point(491, 51);
            lblQueueWaiting.Name = "lblQueueWaiting";
            lblQueueWaiting.Size = new Size(60, 20);
            lblQueueWaiting.TabIndex = 7;
            lblQueueWaiting.Text = "Waiting";
            // 
            // lblQueueServed
            // 
            lblQueueServed.AutoSize = true;
            lblQueueServed.Location = new Point(491, 93);
            lblQueueServed.Name = "lblQueueServed";
            lblQueueServed.Size = new Size(96, 20);
            lblQueueServed.TabIndex = 8;
            lblQueueServed.Text = "Being Served";
            // 
            // lblQueueCheckedIn
            // 
            lblQueueCheckedIn.AutoSize = true;
            lblQueueCheckedIn.Location = new Point(491, 136);
            lblQueueCheckedIn.Name = "lblQueueCheckedIn";
            lblQueueCheckedIn.Size = new Size(81, 20);
            lblQueueCheckedIn.TabIndex = 9;
            lblQueueCheckedIn.Text = "Checked In";
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            pnlQueueManagement.ResumeLayout(false);
            pnlQueueManagement.PerformLayout();
            pnlSearchBookings.ResumeLayout(false);
            pnlSearchBookings.PerformLayout();
            pnlTodaysQueue.ResumeLayout(false);
            pnlTodaysQueue.PerformLayout();
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
        private Panel pnlQueueManagement;
        private Label lblQueueTitle;
        private Label lblSearchTitle;
        private Panel pnlSearchBookings;
        private Label lblQueueDescription;
        private Panel pnlTodaysQueue;
        private Label lblQueueName3;
        private Label lblQueueName2;
        private Label lblQueueName1;
        private Label lblQueueCount3;
        private Label lblQueueCount2;
        private Label lblQueueCount1;
        private Label lblQueueHeading;
        private Label lblSearchDescription;
        private Label lblQueueCheckedIn;
        private Label lblQueueServed;
        private Label lblQueueWaiting;
    }
}