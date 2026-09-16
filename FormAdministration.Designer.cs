namespace SASSAQueueManagementSystem
{
    partial class frmAdministration
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
            pnlSideBar = new Panel();
            btnBookings = new Button();
            btnSlots = new Button();
            btnReports = new Button();
            btnServices = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            pnlToday = new Panel();
            lblTodayBookingsNum = new Label();
            lblToday = new Label();
            pnlNoShows = new Panel();
            lblNoShows = new Label();
            lblNoShowsNum = new Label();
            pnlCompleted = new Panel();
            lblCompletedBookingsNum = new Label();
            lblCompleted = new Label();
            pnlTotalBookings = new Panel();
            lblTotalBookingsNum = new Label();
            lblTotalBookings = new Label();
            pnlMainBtnReports = new Button();
            pnlMainBtnBookings = new Button();
            pnlMainBtnSlots = new Button();
            pnlMainBtnServices = new Button();
            lblExistingGrantApplication = new Label();
            pnlDemandsByService = new Panel();
            lblDemandsByService = new Label();
            lblSassaQueueAndBookingSystem = new Label();
            lblPaymentInquiry = new Label();
            lblGrantInformationUpdate = new Label();
            lblNewGrantApplication = new Label();
            lblDocumentSubmission = new Label();
            pnlRecentBookings = new Panel();
            lblRecentBookings = new Label();
            dgvRecentBookings = new DataGridView();
            reference = new DataGridViewTextBoxColumn();
            beneficiary = new DataGridViewTextBoxColumn();
            service = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            progressbarNewGrant = new ProgressBar();
            progressBarExistingGrant = new ProgressBar();
            progressBarInformationUpdate = new ProgressBar();
            progressBarPaymentInquiry = new ProgressBar();
            progressBarDocuments = new ProgressBar();
            lblGeneralAssistance = new Label();
            progressBarGeneralAssistance = new ProgressBar();
            pnlSideBar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlToday.SuspendLayout();
            pnlNoShows.SuspendLayout();
            pnlCompleted.SuspendLayout();
            pnlTotalBookings.SuspendLayout();
            pnlDemandsByService.SuspendLayout();
            pnlRecentBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnBookings);
            pnlSideBar.Controls.Add(btnSlots);
            pnlSideBar.Controls.Add(btnReports);
            pnlSideBar.Controls.Add(btnServices);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Location = new Point(14, 14);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(159, 492);
            pnlSideBar.TabIndex = 0;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(5, 142);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(148, 36);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnSlots
            // 
            btnSlots.Location = new Point(4, 98);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(148, 38);
            btnSlots.TabIndex = 3;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(5, 184);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(148, 37);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(5, 55);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(148, 37);
            btnServices.TabIndex = 1;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(4, 13);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(148, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlToday);
            pnlMain.Controls.Add(pnlNoShows);
            pnlMain.Controls.Add(pnlCompleted);
            pnlMain.Controls.Add(pnlTotalBookings);
            pnlMain.Controls.Add(pnlMainBtnReports);
            pnlMain.Controls.Add(pnlMainBtnBookings);
            pnlMain.Controls.Add(pnlMainBtnSlots);
            pnlMain.Controls.Add(pnlMainBtnServices);
            pnlMain.Location = new Point(188, 33);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(702, 146);
            pnlMain.TabIndex = 1;
            // 
            // pnlToday
            // 
            pnlToday.BackColor = Color.White;
            pnlToday.Controls.Add(lblTodayBookingsNum);
            pnlToday.Controls.Add(lblToday);
            pnlToday.Location = new Point(530, 15);
            pnlToday.Name = "pnlToday";
            pnlToday.Size = new Size(148, 61);
            pnlToday.TabIndex = 10;
            // 
            // lblTodayBookingsNum
            // 
            lblTodayBookingsNum.AutoSize = true;
            lblTodayBookingsNum.Location = new Point(57, 17);
            lblTodayBookingsNum.Name = "lblTodayBookingsNum";
            lblTodayBookingsNum.Size = new Size(13, 15);
            lblTodayBookingsNum.TabIndex = 11;
            lblTodayBookingsNum.Text = "6";
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Location = new Point(42, 32);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(39, 15);
            lblToday.TabIndex = 10;
            lblToday.Text = "Today";
            // 
            // pnlNoShows
            // 
            pnlNoShows.BackColor = Color.White;
            pnlNoShows.Controls.Add(lblNoShows);
            pnlNoShows.Controls.Add(lblNoShowsNum);
            pnlNoShows.Location = new Point(363, 15);
            pnlNoShows.Name = "pnlNoShows";
            pnlNoShows.Size = new Size(148, 61);
            pnlNoShows.TabIndex = 9;
            // 
            // lblNoShows
            // 
            lblNoShows.AutoSize = true;
            lblNoShows.Location = new Point(44, 32);
            lblNoShows.Name = "lblNoShows";
            lblNoShows.Size = new Size(60, 15);
            lblNoShows.TabIndex = 11;
            lblNoShows.Text = "No Shows";
            // 
            // lblNoShowsNum
            // 
            lblNoShowsNum.AutoSize = true;
            lblNoShowsNum.Location = new Point(68, 17);
            lblNoShowsNum.Name = "lblNoShowsNum";
            lblNoShowsNum.Size = new Size(13, 15);
            lblNoShowsNum.TabIndex = 10;
            lblNoShowsNum.Text = "1";
            // 
            // pnlCompleted
            // 
            pnlCompleted.BackColor = Color.White;
            pnlCompleted.Controls.Add(lblCompletedBookingsNum);
            pnlCompleted.Controls.Add(lblCompleted);
            pnlCompleted.Location = new Point(182, 15);
            pnlCompleted.Name = "pnlCompleted";
            pnlCompleted.Size = new Size(148, 62);
            pnlCompleted.TabIndex = 8;
            // 
            // lblCompletedBookingsNum
            // 
            lblCompletedBookingsNum.AutoSize = true;
            lblCompletedBookingsNum.Location = new Point(58, 17);
            lblCompletedBookingsNum.Name = "lblCompletedBookingsNum";
            lblCompletedBookingsNum.Size = new Size(13, 15);
            lblCompletedBookingsNum.TabIndex = 10;
            lblCompletedBookingsNum.Text = "1";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(30, 32);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(66, 15);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "Completed";
            // 
            // pnlTotalBookings
            // 
            pnlTotalBookings.BackColor = Color.White;
            pnlTotalBookings.Controls.Add(lblTotalBookingsNum);
            pnlTotalBookings.Controls.Add(lblTotalBookings);
            pnlTotalBookings.Location = new Point(3, 15);
            pnlTotalBookings.Name = "pnlTotalBookings";
            pnlTotalBookings.Size = new Size(148, 62);
            pnlTotalBookings.TabIndex = 7;
            // 
            // lblTotalBookingsNum
            // 
            lblTotalBookingsNum.AutoSize = true;
            lblTotalBookingsNum.Location = new Point(44, 17);
            lblTotalBookingsNum.Name = "lblTotalBookingsNum";
            lblTotalBookingsNum.Size = new Size(13, 15);
            lblTotalBookingsNum.TabIndex = 9;
            lblTotalBookingsNum.Text = "8";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Location = new Point(22, 32);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(85, 15);
            lblTotalBookings.TabIndex = 8;
            lblTotalBookings.Text = "Total Bookings";
            // 
            // pnlMainBtnReports
            // 
            pnlMainBtnReports.Location = new Point(530, 82);
            pnlMainBtnReports.Name = "pnlMainBtnReports";
            pnlMainBtnReports.Size = new Size(148, 51);
            pnlMainBtnReports.TabIndex = 6;
            pnlMainBtnReports.Text = "Reports";
            pnlMainBtnReports.UseVisualStyleBackColor = true;
            // 
            // pnlMainBtnBookings
            // 
            pnlMainBtnBookings.Location = new Point(363, 82);
            pnlMainBtnBookings.Name = "pnlMainBtnBookings";
            pnlMainBtnBookings.Size = new Size(148, 51);
            pnlMainBtnBookings.TabIndex = 5;
            pnlMainBtnBookings.Text = "Bookings";
            pnlMainBtnBookings.UseVisualStyleBackColor = true;
            // 
            // pnlMainBtnSlots
            // 
            pnlMainBtnSlots.Location = new Point(182, 82);
            pnlMainBtnSlots.Name = "pnlMainBtnSlots";
            pnlMainBtnSlots.Size = new Size(148, 53);
            pnlMainBtnSlots.TabIndex = 4;
            pnlMainBtnSlots.Text = "Slots";
            pnlMainBtnSlots.UseVisualStyleBackColor = true;
            // 
            // pnlMainBtnServices
            // 
            pnlMainBtnServices.Location = new Point(3, 86);
            pnlMainBtnServices.Name = "pnlMainBtnServices";
            pnlMainBtnServices.Size = new Size(148, 52);
            pnlMainBtnServices.TabIndex = 2;
            pnlMainBtnServices.Text = "Services";
            pnlMainBtnServices.UseVisualStyleBackColor = true;
            // 
            // lblExistingGrantApplication
            // 
            lblExistingGrantApplication.AutoSize = true;
            lblExistingGrantApplication.Location = new Point(25, 82);
            lblExistingGrantApplication.Name = "lblExistingGrantApplication";
            lblExistingGrantApplication.Size = new Size(143, 15);
            lblExistingGrantApplication.TabIndex = 7;
            lblExistingGrantApplication.Text = "Existing Grant Application";
            // 
            // pnlDemandsByService
            // 
            pnlDemandsByService.BackColor = Color.White;
            pnlDemandsByService.Controls.Add(progressBarGeneralAssistance);
            pnlDemandsByService.Controls.Add(lblGeneralAssistance);
            pnlDemandsByService.Controls.Add(progressBarDocuments);
            pnlDemandsByService.Controls.Add(progressBarPaymentInquiry);
            pnlDemandsByService.Controls.Add(progressBarInformationUpdate);
            pnlDemandsByService.Controls.Add(progressBarExistingGrant);
            pnlDemandsByService.Controls.Add(progressbarNewGrant);
            pnlDemandsByService.Controls.Add(lblDocumentSubmission);
            pnlDemandsByService.Controls.Add(lblNewGrantApplication);
            pnlDemandsByService.Controls.Add(lblGrantInformationUpdate);
            pnlDemandsByService.Controls.Add(lblPaymentInquiry);
            pnlDemandsByService.Controls.Add(lblExistingGrantApplication);
            pnlDemandsByService.Controls.Add(lblDemandsByService);
            pnlDemandsByService.Location = new Point(188, 185);
            pnlDemandsByService.Name = "pnlDemandsByService";
            pnlDemandsByService.Size = new Size(702, 197);
            pnlDemandsByService.TabIndex = 2;
            // 
            // lblDemandsByService
            // 
            lblDemandsByService.AutoSize = true;
            lblDemandsByService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDemandsByService.Location = new Point(16, 16);
            lblDemandsByService.Name = "lblDemandsByService";
            lblDemandsByService.Size = new Size(151, 21);
            lblDemandsByService.TabIndex = 0;
            lblDemandsByService.Text = "Demands By Service";
            // 
            // lblSassaQueueAndBookingSystem
            // 
            lblSassaQueueAndBookingSystem.AutoSize = true;
            lblSassaQueueAndBookingSystem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSassaQueueAndBookingSystem.Location = new Point(188, 9);
            lblSassaQueueAndBookingSystem.Name = "lblSassaQueueAndBookingSystem";
            lblSassaQueueAndBookingSystem.Size = new Size(297, 21);
            lblSassaQueueAndBookingSystem.TabIndex = 3;
            lblSassaQueueAndBookingSystem.Text = "SASSA Queue & Booking System Overview";
            // 
            // lblPaymentInquiry
            // 
            lblPaymentInquiry.AutoSize = true;
            lblPaymentInquiry.Location = new Point(25, 130);
            lblPaymentInquiry.Name = "lblPaymentInquiry";
            lblPaymentInquiry.Size = new Size(94, 15);
            lblPaymentInquiry.TabIndex = 8;
            lblPaymentInquiry.Text = "Payment Inquiry";
            // 
            // lblGrantInformationUpdate
            // 
            lblGrantInformationUpdate.AutoSize = true;
            lblGrantInformationUpdate.Location = new Point(25, 106);
            lblGrantInformationUpdate.Name = "lblGrantInformationUpdate";
            lblGrantInformationUpdate.Size = new Size(143, 15);
            lblGrantInformationUpdate.TabIndex = 9;
            lblGrantInformationUpdate.Text = "Grant Information Update";
            // 
            // lblNewGrantApplication
            // 
            lblNewGrantApplication.AutoSize = true;
            lblNewGrantApplication.Location = new Point(25, 56);
            lblNewGrantApplication.Name = "lblNewGrantApplication";
            lblNewGrantApplication.Size = new Size(127, 15);
            lblNewGrantApplication.TabIndex = 10;
            lblNewGrantApplication.Text = "New Grant Application";
            // 
            // lblDocumentSubmission
            // 
            lblDocumentSubmission.AutoSize = true;
            lblDocumentSubmission.Location = new Point(25, 156);
            lblDocumentSubmission.Name = "lblDocumentSubmission";
            lblDocumentSubmission.Size = new Size(127, 15);
            lblDocumentSubmission.TabIndex = 11;
            lblDocumentSubmission.Text = "Document Submission";
            // 
            // pnlRecentBookings
            // 
            pnlRecentBookings.BackColor = Color.White;
            pnlRecentBookings.Controls.Add(dgvRecentBookings);
            pnlRecentBookings.Controls.Add(lblRecentBookings);
            pnlRecentBookings.Location = new Point(188, 388);
            pnlRecentBookings.Name = "pnlRecentBookings";
            pnlRecentBookings.Size = new Size(702, 118);
            pnlRecentBookings.TabIndex = 4;
            // 
            // lblRecentBookings
            // 
            lblRecentBookings.AutoSize = true;
            lblRecentBookings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentBookings.Location = new Point(16, 16);
            lblRecentBookings.Name = "lblRecentBookings";
            lblRecentBookings.Size = new Size(125, 21);
            lblRecentBookings.TabIndex = 0;
            lblRecentBookings.Text = "Recent Bookings";
            // 
            // dgvRecentBookings
            // 
            dgvRecentBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentBookings.Columns.AddRange(new DataGridViewColumn[] { reference, beneficiary, service, date, status });
            dgvRecentBookings.Location = new Point(38, 44);
            dgvRecentBookings.Name = "dgvRecentBookings";
            dgvRecentBookings.Size = new Size(543, 65);
            dgvRecentBookings.TabIndex = 1;
            // 
            // reference
            // 
            reference.HeaderText = "Reference";
            reference.Name = "reference";
            // 
            // beneficiary
            // 
            beneficiary.HeaderText = "Beneficiary";
            beneficiary.Name = "beneficiary";
            // 
            // service
            // 
            service.HeaderText = "Service";
            service.Name = "service";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // progressbarNewGrant
            // 
            progressbarNewGrant.BackColor = Color.AliceBlue;
            progressbarNewGrant.Location = new Point(179, 56);
            progressbarNewGrant.Name = "progressbarNewGrant";
            progressbarNewGrant.Size = new Size(184, 16);
            progressbarNewGrant.TabIndex = 12;
            // 
            // progressBarExistingGrant
            // 
            progressBarExistingGrant.Location = new Point(179, 78);
            progressBarExistingGrant.Name = "progressBarExistingGrant";
            progressBarExistingGrant.Size = new Size(160, 21);
            progressBarExistingGrant.TabIndex = 13;
            // 
            // progressBarInformationUpdate
            // 
            progressBarInformationUpdate.Location = new Point(179, 104);
            progressBarInformationUpdate.Name = "progressBarInformationUpdate";
            progressBarInformationUpdate.Size = new Size(123, 17);
            progressBarInformationUpdate.TabIndex = 14;
            // 
            // progressBarPaymentInquiry
            // 
            progressBarPaymentInquiry.Location = new Point(179, 127);
            progressBarPaymentInquiry.Name = "progressBarPaymentInquiry";
            progressBarPaymentInquiry.Size = new Size(174, 20);
            progressBarPaymentInquiry.TabIndex = 15;
            // 
            // progressBarDocuments
            // 
            progressBarDocuments.Location = new Point(179, 153);
            progressBarDocuments.Name = "progressBarDocuments";
            progressBarDocuments.Size = new Size(123, 17);
            progressBarDocuments.TabIndex = 16;
            // 
            // lblGeneralAssistance
            // 
            lblGeneralAssistance.AutoSize = true;
            lblGeneralAssistance.Location = new Point(25, 182);
            lblGeneralAssistance.Name = "lblGeneralAssistance";
            lblGeneralAssistance.Size = new Size(105, 15);
            lblGeneralAssistance.TabIndex = 17;
            lblGeneralAssistance.Text = "General Assistance";
            // 
            // progressBarGeneralAssistance
            // 
            progressBarGeneralAssistance.Location = new Point(179, 176);
            progressBarGeneralAssistance.Name = "progressBarGeneralAssistance";
            progressBarGeneralAssistance.Size = new Size(118, 17);
            progressBarGeneralAssistance.TabIndex = 18;
            // 
            // frmAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 510);
            Controls.Add(pnlRecentBookings);
            Controls.Add(lblSassaQueueAndBookingSystem);
            Controls.Add(pnlDemandsByService);
            Controls.Add(pnlMain);
            Controls.Add(pnlSideBar);
            Name = "frmAdministration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administration";
            pnlSideBar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlToday.ResumeLayout(false);
            pnlToday.PerformLayout();
            pnlNoShows.ResumeLayout(false);
            pnlNoShows.PerformLayout();
            pnlCompleted.ResumeLayout(false);
            pnlCompleted.PerformLayout();
            pnlTotalBookings.ResumeLayout(false);
            pnlTotalBookings.PerformLayout();
            pnlDemandsByService.ResumeLayout(false);
            pnlDemandsByService.PerformLayout();
            pnlRecentBookings.ResumeLayout(false);
            pnlRecentBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideBar;
        private Button btnBookings;
        private Button btnSlots;
        private Button btnReports;
        private Button btnServices;
        private Button btnDashboard;
        private Panel pnlMain;
        private Button pnlMainBtnServices;
        private Button pnlMainBtnReports;
        private Button pnlMainBtnBookings;
        private Button pnlMainBtnSlots;
        private Panel pnlDemandsByService;
        private Label lblDemandsByService;
        private Label lblExistingGrantApplication;
        private Label lblSassaQueueAndBookingSystem;
        private Panel pnlTotalBookings;
        private Panel pnlToday;
        private Panel pnlNoShows;
        private Panel pnlCompleted;
        private Label lblTotalBookings;
        private Label lblTotalBookingsNum;
        private Label lblNoShowsNum;
        private Label lblCompletedBookingsNum;
        private Label lblCompleted;
        private Label lblToday;
        private Label lblNoShows;
        private Label lblTodayBookingsNum;
        private Label lblDocumentSubmission;
        private Label lblNewGrantApplication;
        private Label lblGrantInformationUpdate;
        private Label lblPaymentInquiry;
        private Panel pnlRecentBookings;
        private DataGridView dgvRecentBookings;
        private Label lblRecentBookings;
        private DataGridViewTextBoxColumn reference;
        private DataGridViewTextBoxColumn beneficiary;
        private DataGridViewTextBoxColumn service;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn status;
        private ProgressBar progressBarDocuments;
        private ProgressBar progressBarPaymentInquiry;
        private ProgressBar progressBarInformationUpdate;
        private ProgressBar progressBarExistingGrant;
        private ProgressBar progressbarNewGrant;
        private ProgressBar progressBarGeneralAssistance;
        private Label lblGeneralAssistance;
    }
}