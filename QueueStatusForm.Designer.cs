
namespace Sassa_Queue_And_Service_Management_System
{
    partial class QueueStatusForm
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
            components = new System.ComponentModel.Container();
            pnlQueueStatus = new Panel();
            lblBeneficiaryPortal = new Label();
            lblTrackPosition = new Label();
            lblQueueStatus = new Label();
            lblSassa = new Label();
            pnlSideBar = new Panel();
            btnLogout = new Button();
            btnMyProfile = new Button();
            btnQueueStatus = new Button();
            btnMyBooking = new Button();
            btnNewBooking = new Button();
            btnDashboard = new Button();
            lblQueueNumber = new Label();
            pnlQueueDetails = new Panel();
            lblQueueMessage = new Label();
            lblPeopleAhead = new Label();
            lblCheckInTime = new Label();
            lblCentreName = new Label();
            lblCurrentStatus = new Label();
            lblServiceName = new Label();
            btnBack = new Button();
            btnRefresh = new Button();
            tmrQueueRefresh = new System.Windows.Forms.Timer(components);
            pnlQueueStatus.SuspendLayout();
            pnlSideBar.SuspendLayout();
            pnlQueueDetails.SuspendLayout();
            SuspendLayout();
            // 
            // pnlQueueStatus
            // 
            pnlQueueStatus.BackColor = Color.FromArgb(0, 51, 102);
            pnlQueueStatus.Controls.Add(lblBeneficiaryPortal);
            pnlQueueStatus.Controls.Add(lblTrackPosition);
            pnlQueueStatus.Controls.Add(lblQueueStatus);
            pnlQueueStatus.Controls.Add(lblSassa);
            pnlQueueStatus.Dock = DockStyle.Top;
            pnlQueueStatus.Location = new Point(0, 0);
            pnlQueueStatus.Margin = new Padding(4, 3, 4, 3);
            pnlQueueStatus.Name = "pnlQueueStatus";
            pnlQueueStatus.Size = new Size(962, 75);
            pnlQueueStatus.TabIndex = 0;
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeneficiaryPortal.ForeColor = Color.White;
            lblBeneficiaryPortal.Location = new Point(840, 24);
            lblBeneficiaryPortal.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(107, 13);
            lblBeneficiaryPortal.TabIndex = 1;
            lblBeneficiaryPortal.Text = "Beneficiary Portal";
            // 
            // lblTrackPosition
            // 
            lblTrackPosition.AutoSize = true;
            lblTrackPosition.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrackPosition.ForeColor = Color.White;
            lblTrackPosition.Location = new Point(117, 38);
            lblTrackPosition.Margin = new Padding(4, 0, 4, 0);
            lblTrackPosition.Name = "lblTrackPosition";
            lblTrackPosition.Size = new Size(216, 13);
            lblTrackPosition.TabIndex = 2;
            lblTrackPosition.Text = "Track your position after checking in";
            // 
            // lblQueueStatus
            // 
            lblQueueStatus.AutoSize = true;
            lblQueueStatus.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueueStatus.ForeColor = Color.White;
            lblQueueStatus.Location = new Point(113, 15);
            lblQueueStatus.Margin = new Padding(4, 0, 4, 0);
            lblQueueStatus.Name = "lblQueueStatus";
            lblQueueStatus.Size = new Size(110, 18);
            lblQueueStatus.TabIndex = 1;
            lblQueueStatus.Text = "Queue Status";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(15, 15);
            lblSassa.Margin = new Padding(4, 0, 4, 0);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(77, 24);
            lblSassa.TabIndex = 0;
            lblSassa.Text = "SASSA";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.WhiteSmoke;
            pnlSideBar.Controls.Add(btnLogout);
            pnlSideBar.Controls.Add(btnMyProfile);
            pnlSideBar.Controls.Add(btnQueueStatus);
            pnlSideBar.Controls.Add(btnMyBooking);
            pnlSideBar.Controls.Add(btnNewBooking);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Location = new Point(0, 83);
            pnlSideBar.Margin = new Padding(4, 3, 4, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(190, 515);
            pnlSideBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(42, 253);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 39);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnSignOut_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(42, 208);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(129, 39);
            btnMyProfile.TabIndex = 13;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnProfile_Click;
            // 
            // btnQueueStatus
            // 
            btnQueueStatus.Location = new Point(42, 163);
            btnQueueStatus.Name = "btnQueueStatus";
            btnQueueStatus.Size = new Size(129, 39);
            btnQueueStatus.TabIndex = 12;
            btnQueueStatus.Text = "Queue Status";
            btnQueueStatus.UseVisualStyleBackColor = true;
            btnQueueStatus.Click += btnQueueStatus_Click;
            // 
            // btnMyBooking
            // 
            btnMyBooking.Location = new Point(42, 118);
            btnMyBooking.Name = "btnMyBooking";
            btnMyBooking.Size = new Size(129, 39);
            btnMyBooking.TabIndex = 11;
            btnMyBooking.Text = "My Booking";
            btnMyBooking.UseVisualStyleBackColor = true;
            btnMyBooking.Click += btnMyBooking_Click;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Location = new Point(42, 73);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(129, 39);
            btnNewBooking.TabIndex = 10;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(42, 25);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(129, 39);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblQueueNumber
            // 
            lblQueueNumber.AutoSize = true;
            lblQueueNumber.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueueNumber.ForeColor = Color.FromArgb(0, 51, 102);
            lblQueueNumber.Location = new Point(4, 11);
            lblQueueNumber.Margin = new Padding(4, 0, 4, 0);
            lblQueueNumber.Name = "lblQueueNumber";
            lblQueueNumber.Size = new Size(81, 31);
            lblQueueNumber.TabIndex = 3;
            lblQueueNumber.Text = "A024";
            // 
            // pnlQueueDetails
            // 
            pnlQueueDetails.BackColor = Color.WhiteSmoke;
            pnlQueueDetails.Controls.Add(lblQueueMessage);
            pnlQueueDetails.Controls.Add(lblPeopleAhead);
            pnlQueueDetails.Controls.Add(lblCheckInTime);
            pnlQueueDetails.Controls.Add(lblCentreName);
            pnlQueueDetails.Controls.Add(lblCurrentStatus);
            pnlQueueDetails.Controls.Add(lblServiceName);
            pnlQueueDetails.Controls.Add(lblQueueNumber);
            pnlQueueDetails.Location = new Point(226, 83);
            pnlQueueDetails.Margin = new Padding(4, 3, 4, 3);
            pnlQueueDetails.Name = "pnlQueueDetails";
            pnlQueueDetails.Size = new Size(470, 443);
            pnlQueueDetails.TabIndex = 4;
            // 
            // lblQueueMessage
            // 
            lblQueueMessage.AutoSize = true;
            lblQueueMessage.ForeColor = SystemColors.ControlDarkDark;
            lblQueueMessage.Location = new Point(4, 199);
            lblQueueMessage.Margin = new Padding(4, 0, 4, 0);
            lblQueueMessage.Name = "lblQueueMessage";
            lblQueueMessage.Size = new Size(91, 15);
            lblQueueMessage.TabIndex = 9;
            lblQueueMessage.Text = "Queue Message";
            // 
            // lblPeopleAhead
            // 
            lblPeopleAhead.AutoSize = true;
            lblPeopleAhead.ForeColor = SystemColors.ControlDarkDark;
            lblPeopleAhead.Location = new Point(4, 150);
            lblPeopleAhead.Margin = new Padding(4, 0, 4, 0);
            lblPeopleAhead.Name = "lblPeopleAhead";
            lblPeopleAhead.Size = new Size(80, 15);
            lblPeopleAhead.TabIndex = 7;
            lblPeopleAhead.Text = "People Ahead";
            // 
            // lblCheckInTime
            // 
            lblCheckInTime.AutoSize = true;
            lblCheckInTime.ForeColor = SystemColors.ControlDarkDark;
            lblCheckInTime.Location = new Point(4, 124);
            lblCheckInTime.Margin = new Padding(4, 0, 4, 0);
            lblCheckInTime.Name = "lblCheckInTime";
            lblCheckInTime.Size = new Size(83, 15);
            lblCheckInTime.TabIndex = 6;
            lblCheckInTime.Text = "Check In Time";
            // 
            // lblCentreName
            // 
            lblCentreName.AutoSize = true;
            lblCentreName.ForeColor = SystemColors.ControlDarkDark;
            lblCentreName.Location = new Point(4, 100);
            lblCentreName.Margin = new Padding(4, 0, 4, 0);
            lblCentreName.Name = "lblCentreName";
            lblCentreName.Size = new Size(77, 15);
            lblCentreName.TabIndex = 5;
            lblCentreName.Text = "Centre Name";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.ForeColor = SystemColors.ControlDarkDark;
            lblCurrentStatus.Location = new Point(4, 49);
            lblCurrentStatus.Margin = new Padding(4, 0, 4, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(82, 15);
            lblCurrentStatus.TabIndex = 4;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.ForeColor = SystemColors.ControlDarkDark;
            lblServiceName.Location = new Point(4, 73);
            lblServiceName.Margin = new Padding(4, 0, 4, 0);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(79, 15);
            lblServiceName.TabIndex = 1;
            lblServiceName.Text = "Service Name";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 51, 102);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(226, 561);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(167, 37);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 51, 102);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(429, 561);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(167, 37);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tmrQueueRefresh
            // 
            tmrQueueRefresh.Tick += tmrQueueRefresh_Tick;
            // 
            // QueueStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 247);
            ClientSize = new Size(962, 600);
            Controls.Add(btnRefresh);
            Controls.Add(btnBack);
            Controls.Add(pnlQueueDetails);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlQueueStatus);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QueueStatusForm";
            Text = "QueueStatusForm";
            WindowState = FormWindowState.Maximized;
            Load += QueueStatusForm_Load;
            pnlQueueStatus.ResumeLayout(false);
            pnlQueueStatus.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlQueueDetails.ResumeLayout(false);
            pnlQueueDetails.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQueueStatus;
        private System.Windows.Forms.Label lblBeneficiaryPortal;
        private System.Windows.Forms.Label lblTrackPosition;
        private System.Windows.Forms.Label lblQueueStatus;
        private System.Windows.Forms.Label lblSassa;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label lblQueueNumber;
        private System.Windows.Forms.Panel pnlQueueDetails;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Panel pnlEstimatedWait;
        private System.Windows.Forms.Label lbl35Minutes;
        private System.Windows.Forms.Label lblEstimatedWait;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQueueProgress;
        private System.Windows.Forms.Label lblQueueProgress2;
        private System.Windows.Forms.Button btnBack;
        private Button btnRefresh;
        private Label lblQueueMessage;
        //private Label lblEstimatedWait;
        private Label lblPeopleAhead;
        private Label lblCheckInTime;
        private Label lblCentreName;
        private Label lblCurrentStatus;
        private System.Windows.Forms.Timer tmrQueueRefresh;
        private Button btnDashboard;
        private Button btnQueueStatus;
        private Button btnMyBooking;
        private Button btnNewBooking;
        private Button btnLogout;
        private Button btnMyProfile;
    }
}