namespace Sassa_Queue_And_Service_Management_System
{
    partial class NewBookingForm
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
            NewBookingpanel = new Panel();
            lblbookingnewone = new Label();
            lblPortal = new Label();
            lblmanage = new Label();
            lblSassa = new Label();
            menuePanel = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnQueueStatus = new Button();
            btnMyBooking = new Button();
            btnNewBooking = new Button();
            btnDashboard = new Button();
            lblBooking = new Label();
            lblbookyourappointment = new Label();
            lblSelectService = new Label();
            lblServiceCentre = new Label();
            lblSelectDate = new Label();
            lblSummary = new Label();
            lblSelectTime = new Label();
            cmbSelectService = new ComboBox();
            cmbServiceCentre = new ComboBox();
            cmbTime = new ComboBox();
            dtpDate = new DateTimePicker();
            btnCancel = new Button();
            btnConfirmbooking = new Button();
            dgvSummary = new DataGridView();
            colSelectedService = new DataGridViewTextBoxColumn();
            colServiceCentre = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            NewBookingpanel.SuspendLayout();
            menuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // NewBookingpanel
            // 
            NewBookingpanel.BackColor = Color.FromArgb(26, 74, 122);
            NewBookingpanel.Controls.Add(lblbookingnewone);
            NewBookingpanel.Controls.Add(lblPortal);
            NewBookingpanel.Controls.Add(lblmanage);
            NewBookingpanel.Controls.Add(lblSassa);
            NewBookingpanel.Location = new Point(3, 4);
            NewBookingpanel.Margin = new Padding(3, 4, 3, 4);
            NewBookingpanel.Name = "NewBookingpanel";
            NewBookingpanel.Size = new Size(1356, 98);
            NewBookingpanel.TabIndex = 27;
            // 
            // lblbookingnewone
            // 
            lblbookingnewone.AutoSize = true;
            lblbookingnewone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbookingnewone.ForeColor = SystemColors.Control;
            lblbookingnewone.Location = new Point(127, 24);
            lblbookingnewone.Name = "lblbookingnewone";
            lblbookingnewone.Size = new Size(127, 22);
            lblbookingnewone.TabIndex = 20;
            lblbookingnewone.Text = "New Booking";
            // 
            // lblPortal
            // 
            lblPortal.AutoSize = true;
            lblPortal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPortal.ForeColor = SystemColors.Control;
            lblPortal.Location = new Point(1084, 27);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(142, 20);
            lblPortal.TabIndex = 19;
            lblPortal.Text = "Beneficiary Portal";
            // 
            // lblmanage
            // 
            lblmanage.AutoSize = true;
            lblmanage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmanage.ForeColor = SystemColors.Control;
            lblmanage.Location = new Point(118, 69);
            lblmanage.Name = "lblmanage";
            lblmanage.Size = new Size(315, 18);
            lblmanage.TabIndex = 18;
            lblmanage.Text = "Manage your booking, profile and queue status";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = SystemColors.Control;
            lblSassa.Location = new Point(12, 27);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(96, 29);
            lblSassa.TabIndex = 17;
            lblSassa.Text = "SASSA";
            // 
            // menuePanel
            // 
            menuePanel.BackColor = Color.White;
            menuePanel.Controls.Add(btnLogout);
            menuePanel.Controls.Add(btnProfile);
            menuePanel.Controls.Add(btnQueueStatus);
            menuePanel.Controls.Add(btnMyBooking);
            menuePanel.Controls.Add(btnNewBooking);
            menuePanel.Controls.Add(btnDashboard);
            menuePanel.Location = new Point(14, 111);
            menuePanel.Margin = new Padding(3, 4, 3, 4);
            menuePanel.Name = "menuePanel";
            menuePanel.Size = new Size(206, 778);
            menuePanel.TabIndex = 28;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(18, 467);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 58);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(18, 387);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(162, 58);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnQueueStatus
            // 
            btnQueueStatus.Location = new Point(18, 302);
            btnQueueStatus.Margin = new Padding(3, 4, 3, 4);
            btnQueueStatus.Name = "btnQueueStatus";
            btnQueueStatus.Size = new Size(162, 58);
            btnQueueStatus.TabIndex = 3;
            btnQueueStatus.Text = "Queue Status";
            btnQueueStatus.UseVisualStyleBackColor = true;
            // 
            // btnMyBooking
            // 
            btnMyBooking.Location = new Point(18, 223);
            btnMyBooking.Margin = new Padding(3, 4, 3, 4);
            btnMyBooking.Name = "btnMyBooking";
            btnMyBooking.Size = new Size(162, 58);
            btnMyBooking.TabIndex = 2;
            btnMyBooking.Text = "My Booking";
            btnMyBooking.UseVisualStyleBackColor = true;
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.FromArgb(26, 74, 122);
            btnNewBooking.ForeColor = SystemColors.Control;
            btnNewBooking.Location = new Point(18, 148);
            btnNewBooking.Margin = new Padding(3, 4, 3, 4);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(162, 58);
            btnNewBooking.TabIndex = 1;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(18, 68);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(162, 58);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooking.Location = new Point(610, 142);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(151, 22);
            lblBooking.TabIndex = 29;
            lblBooking.Text = "NEW BOOKING";
            // 
            // lblbookyourappointment
            // 
            lblbookyourappointment.AutoSize = true;
            lblbookyourappointment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbookyourappointment.Location = new Point(546, 188);
            lblbookyourappointment.Name = "lblbookyourappointment";
            lblbookyourappointment.Size = new Size(286, 22);
            lblbookyourappointment.TabIndex = 30;
            lblbookyourappointment.Text = "Book your SASSA appointment";
            // 
            // lblSelectService
            // 
            lblSelectService.AutoSize = true;
            lblSelectService.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectService.Location = new Point(271, 272);
            lblSelectService.Name = "lblSelectService";
            lblSelectService.Size = new Size(115, 20);
            lblSelectService.TabIndex = 31;
            lblSelectService.Text = "Select service";
            // 
            // lblServiceCentre
            // 
            lblServiceCentre.AutoSize = true;
            lblServiceCentre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceCentre.Location = new Point(271, 413);
            lblServiceCentre.Name = "lblServiceCentre";
            lblServiceCentre.Size = new Size(167, 20);
            lblServiceCentre.TabIndex = 32;
            lblServiceCentre.Text = "Select service centre";
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectDate.Location = new Point(271, 549);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(97, 20);
            lblSelectDate.TabIndex = 33;
            lblSelectDate.Text = "Select Date";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(845, 259);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(183, 20);
            lblSummary.TabIndex = 34;
            lblSummary.Text = " Appointment Summary";
            // 
            // lblSelectTime
            // 
            lblSelectTime.AutoSize = true;
            lblSelectTime.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectTime.Location = new Point(271, 668);
            lblSelectTime.Name = "lblSelectTime";
            lblSelectTime.Size = new Size(98, 20);
            lblSelectTime.TabIndex = 35;
            lblSelectTime.Text = "Select Time";
            // 
            // cmbSelectService
            // 
            cmbSelectService.FormattingEnabled = true;
            cmbSelectService.Items.AddRange(new object[] { "New Grant Application", "Existing Grant Enquiry", "Grant Information Update", "Payment Enquiry", "Document Submission", "General Assistance" });
            cmbSelectService.Location = new Point(276, 334);
            cmbSelectService.Margin = new Padding(3, 4, 3, 4);
            cmbSelectService.Name = "cmbSelectService";
            cmbSelectService.Size = new Size(402, 31);
            cmbSelectService.TabIndex = 36;
            cmbSelectService.Text = "Select a service";
            // 
            // cmbServiceCentre
            // 
            cmbServiceCentre.FormattingEnabled = true;
            cmbServiceCentre.Items.AddRange(new object[] { "Johannesburg Central SASSA Centre", "Soweto SASSA Centre", "Alexandra SASSA Centre ", "Roodepoort SASSA Centre " });
            cmbServiceCentre.Location = new Point(276, 480);
            cmbServiceCentre.Margin = new Padding(3, 4, 3, 4);
            cmbServiceCentre.Name = "cmbServiceCentre";
            cmbServiceCentre.Size = new Size(402, 31);
            cmbServiceCentre.TabIndex = 37;
            cmbServiceCentre.Text = "Select a service centre";
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Items.AddRange(new object[] { "08:00 - 08:30", "08:30 - 09:00", "09:00 - 09:30", "09:30 - 10:00", "10:00 - 10:30", "10:30 - 11:00" });
            cmbTime.Location = new Point(276, 726);
            cmbTime.Margin = new Padding(3, 4, 3, 4);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(332, 31);
            cmbTime.TabIndex = 39;
            cmbTime.Text = "Available Time Slots";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(276, 604);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(332, 30);
            dtpDate.TabIndex = 40;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(718, 752);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(254, 70);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmbooking
            // 
            btnConfirmbooking.Location = new Point(1080, 752);
            btnConfirmbooking.Margin = new Padding(3, 4, 3, 4);
            btnConfirmbooking.Name = "btnConfirmbooking";
            btnConfirmbooking.Size = new Size(259, 70);
            btnConfirmbooking.TabIndex = 42;
            btnConfirmbooking.Text = "Confirm Booking";
            btnConfirmbooking.UseVisualStyleBackColor = true;
            // 
            // dgvSummary
            // 
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Columns.AddRange(new DataGridViewColumn[] { colSelectedService, colServiceCentre, colDate, colTime });
            dgvSummary.Location = new Point(718, 299);
            dgvSummary.Margin = new Padding(3, 4, 3, 4);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.RowTemplate.Height = 24;
            dgvSummary.Size = new Size(621, 420);
            dgvSummary.TabIndex = 43;
            // 
            // colSelectedService
            // 
            colSelectedService.HeaderText = "Service";
            colSelectedService.MinimumWidth = 6;
            colSelectedService.Name = "colSelectedService";
            // 
            // colServiceCentre
            // 
            colServiceCentre.HeaderText = "Service Centre";
            colServiceCentre.MinimumWidth = 6;
            colServiceCentre.Name = "colServiceCentre";
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 900);
            Controls.Add(dgvSummary);
            Controls.Add(btnConfirmbooking);
            Controls.Add(btnCancel);
            Controls.Add(dtpDate);
            Controls.Add(cmbTime);
            Controls.Add(cmbServiceCentre);
            Controls.Add(cmbSelectService);
            Controls.Add(lblSelectTime);
            Controls.Add(lblSummary);
            Controls.Add(lblSelectDate);
            Controls.Add(lblServiceCentre);
            Controls.Add(lblSelectService);
            Controls.Add(lblbookyourappointment);
            Controls.Add(lblBooking);
            Controls.Add(menuePanel);
            Controls.Add(NewBookingpanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewBookingForm";
            Text = "NewBookingForm";
            NewBookingpanel.ResumeLayout(false);
            NewBookingpanel.PerformLayout();
            menuePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NewBookingpanel;
        private System.Windows.Forms.Label lblbookingnewone;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.Label lblmanage;
        private System.Windows.Forms.Label lblSassa;
        private System.Windows.Forms.Panel menuePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnQueueStatus;
        private System.Windows.Forms.Button btnMyBooking;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblbookyourappointment;
        private System.Windows.Forms.Label lblSelectService;
        private System.Windows.Forms.Label lblServiceCentre;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSelectTime;
        private System.Windows.Forms.ComboBox cmbSelectService;
        private System.Windows.Forms.ComboBox cmbServiceCentre;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmbooking;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCentre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
    }
}