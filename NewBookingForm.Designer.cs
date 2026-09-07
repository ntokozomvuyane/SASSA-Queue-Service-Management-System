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
            this.NewBookingpanel = new System.Windows.Forms.Panel();
            this.lblbookingnewone = new System.Windows.Forms.Label();
            this.lblPortal = new System.Windows.Forms.Label();
            this.lblmanage = new System.Windows.Forms.Label();
            this.lblSassa = new System.Windows.Forms.Label();
            this.menuePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQueueStatus = new System.Windows.Forms.Button();
            this.btnMyBooking = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblbookyourappointment = new System.Windows.Forms.Label();
            this.lblSelectService = new System.Windows.Forms.Label();
            this.lblServiceCentre = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSelectTime = new System.Windows.Forms.Label();
            this.cmbSelectService = new System.Windows.Forms.ComboBox();
            this.cmbServiceCentre = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmbooking = new System.Windows.Forms.Button();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.colSelectedService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceCentre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewBookingpanel.SuspendLayout();
            this.menuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // NewBookingpanel
            // 
            this.NewBookingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.NewBookingpanel.Controls.Add(this.lblbookingnewone);
            this.NewBookingpanel.Controls.Add(this.lblPortal);
            this.NewBookingpanel.Controls.Add(this.lblmanage);
            this.NewBookingpanel.Controls.Add(this.lblSassa);
            this.NewBookingpanel.Location = new System.Drawing.Point(3, 3);
            this.NewBookingpanel.Name = "NewBookingpanel";
            this.NewBookingpanel.Size = new System.Drawing.Size(1205, 68);
            this.NewBookingpanel.TabIndex = 27;
            // 
            // lblbookingnewone
            // 
            this.lblbookingnewone.AutoSize = true;
            this.lblbookingnewone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookingnewone.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbookingnewone.Location = new System.Drawing.Point(113, 17);
            this.lblbookingnewone.Name = "lblbookingnewone";
            this.lblbookingnewone.Size = new System.Drawing.Size(127, 22);
            this.lblbookingnewone.TabIndex = 20;
            this.lblbookingnewone.Text = "New Booking";
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPortal.Location = new System.Drawing.Point(964, 19);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(142, 20);
            this.lblPortal.TabIndex = 19;
            this.lblPortal.Text = "Beneficiary Portal";
            // 
            // lblmanage
            // 
            this.lblmanage.AutoSize = true;
            this.lblmanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmanage.Location = new System.Drawing.Point(105, 48);
            this.lblmanage.Name = "lblmanage";
            this.lblmanage.Size = new System.Drawing.Size(315, 18);
            this.lblmanage.TabIndex = 18;
            this.lblmanage.Text = "Manage your booking, profile and queue status";
            // 
            // lblSassa
            // 
            this.lblSassa.AutoSize = true;
            this.lblSassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSassa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSassa.Location = new System.Drawing.Point(11, 19);
            this.lblSassa.Name = "lblSassa";
            this.lblSassa.Size = new System.Drawing.Size(96, 29);
            this.lblSassa.TabIndex = 17;
            this.lblSassa.Text = "SASSA";
            // 
            // menuePanel
            // 
            this.menuePanel.BackColor = System.Drawing.Color.White;
            this.menuePanel.Controls.Add(this.btnLogout);
            this.menuePanel.Controls.Add(this.btnProfile);
            this.menuePanel.Controls.Add(this.btnQueueStatus);
            this.menuePanel.Controls.Add(this.btnMyBooking);
            this.menuePanel.Controls.Add(this.btnNewBooking);
            this.menuePanel.Controls.Add(this.btnDashboard);
            this.menuePanel.Location = new System.Drawing.Point(12, 77);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(183, 541);
            this.menuePanel.TabIndex = 28;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(16, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(16, 269);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(144, 40);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnQueueStatus
            // 
            this.btnQueueStatus.Location = new System.Drawing.Point(16, 210);
            this.btnQueueStatus.Name = "btnQueueStatus";
            this.btnQueueStatus.Size = new System.Drawing.Size(144, 40);
            this.btnQueueStatus.TabIndex = 3;
            this.btnQueueStatus.Text = "Queue Status";
            this.btnQueueStatus.UseVisualStyleBackColor = true;
            // 
            // btnMyBooking
            // 
            this.btnMyBooking.Location = new System.Drawing.Point(16, 155);
            this.btnMyBooking.Name = "btnMyBooking";
            this.btnMyBooking.Size = new System.Drawing.Size(144, 40);
            this.btnMyBooking.TabIndex = 2;
            this.btnMyBooking.Text = "My Booking";
            this.btnMyBooking.UseVisualStyleBackColor = true;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.btnNewBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewBooking.Location = new System.Drawing.Point(16, 103);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(144, 40);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(16, 47);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(144, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(542, 99);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(151, 22);
            this.lblBooking.TabIndex = 29;
            this.lblBooking.Text = "NEW BOOKING";
            // 
            // lblbookyourappointment
            // 
            this.lblbookyourappointment.AutoSize = true;
            this.lblbookyourappointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbookyourappointment.Location = new System.Drawing.Point(485, 131);
            this.lblbookyourappointment.Name = "lblbookyourappointment";
            this.lblbookyourappointment.Size = new System.Drawing.Size(286, 22);
            this.lblbookyourappointment.TabIndex = 30;
            this.lblbookyourappointment.Text = "Book your SASSA appointment";
            // 
            // lblSelectService
            // 
            this.lblSelectService.AutoSize = true;
            this.lblSelectService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectService.Location = new System.Drawing.Point(241, 189);
            this.lblSelectService.Name = "lblSelectService";
            this.lblSelectService.Size = new System.Drawing.Size(115, 20);
            this.lblSelectService.TabIndex = 31;
            this.lblSelectService.Text = "Select service";
            // 
            // lblServiceCentre
            // 
            this.lblServiceCentre.AutoSize = true;
            this.lblServiceCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCentre.Location = new System.Drawing.Point(241, 287);
            this.lblServiceCentre.Name = "lblServiceCentre";
            this.lblServiceCentre.Size = new System.Drawing.Size(167, 20);
            this.lblServiceCentre.TabIndex = 32;
            this.lblServiceCentre.Text = "Select service centre";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(241, 382);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(97, 20);
            this.lblSelectDate.TabIndex = 33;
            this.lblSelectDate.Text = "Select Date";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(751, 180);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(183, 20);
            this.lblSummary.TabIndex = 34;
            this.lblSummary.Text = " Appointment Summary";
            // 
            // lblSelectTime
            // 
            this.lblSelectTime.AutoSize = true;
            this.lblSelectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTime.Location = new System.Drawing.Point(241, 465);
            this.lblSelectTime.Name = "lblSelectTime";
            this.lblSelectTime.Size = new System.Drawing.Size(98, 20);
            this.lblSelectTime.TabIndex = 35;
            this.lblSelectTime.Text = "Select Time";
            // 
            // cmbSelectService
            // 
            this.cmbSelectService.FormattingEnabled = true;
            this.cmbSelectService.Items.AddRange(new object[] {
            "New Grant Application",
            "Existing Grant Enquiry",
            "Grant Information Update",
            "Payment Enquiry",
            "Document Submission",
            "General Assistance"});
            this.cmbSelectService.Location = new System.Drawing.Point(245, 232);
            this.cmbSelectService.Name = "cmbSelectService";
            this.cmbSelectService.Size = new System.Drawing.Size(358, 24);
            this.cmbSelectService.TabIndex = 36;
            this.cmbSelectService.Text = "Select a service";
            // 
            // cmbServiceCentre
            // 
            this.cmbServiceCentre.FormattingEnabled = true;
            this.cmbServiceCentre.Items.AddRange(new object[] {
            "Johannesburg Central SASSA Centre",
            "Soweto SASSA Centre",
            "Alexandra SASSA Centre ",
            "Roodepoort SASSA Centre "});
            this.cmbServiceCentre.Location = new System.Drawing.Point(245, 334);
            this.cmbServiceCentre.Name = "cmbServiceCentre";
            this.cmbServiceCentre.Size = new System.Drawing.Size(358, 24);
            this.cmbServiceCentre.TabIndex = 37;
            this.cmbServiceCentre.Text = "Select a service centre";
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "08:00 - 08:30",
            "08:30 - 09:00",
            "09:00 - 09:30",
            "09:30 - 10:00",
            "10:00 - 10:30",
            "10:30 - 11:00"});
            this.cmbTime.Location = new System.Drawing.Point(245, 505);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(296, 24);
            this.cmbTime.TabIndex = 39;
            this.cmbTime.Text = "Available Time Slots";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(245, 420);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(296, 22);
            this.dtpDate.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(638, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(226, 49);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmbooking
            // 
            this.btnConfirmbooking.Location = new System.Drawing.Point(960, 523);
            this.btnConfirmbooking.Name = "btnConfirmbooking";
            this.btnConfirmbooking.Size = new System.Drawing.Size(230, 49);
            this.btnConfirmbooking.TabIndex = 42;
            this.btnConfirmbooking.Text = "Confirm Booking";
            this.btnConfirmbooking.UseVisualStyleBackColor = true;
            this.btnConfirmbooking.Click += new System.EventHandler(this.btnConfirmbooking_Click);
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectedService,
            this.colServiceCentre,
            this.colDate,
            this.colTime});
            this.dgvSummary.Location = new System.Drawing.Point(638, 208);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowHeadersWidth = 51;
            this.dgvSummary.RowTemplate.Height = 24;
            this.dgvSummary.Size = new System.Drawing.Size(552, 292);
            this.dgvSummary.TabIndex = 43;
            // 
            // colSelectedService
            // 
            this.colSelectedService.HeaderText = "Service";
            this.colSelectedService.MinimumWidth = 6;
            this.colSelectedService.Name = "colSelectedService";
            this.colSelectedService.Width = 125;
            // 
            // colServiceCentre
            // 
            this.colServiceCentre.HeaderText = "Service Centre";
            this.colServiceCentre.MinimumWidth = 6;
            this.colServiceCentre.Name = "colServiceCentre";
            this.colServiceCentre.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 125;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.Width = 125;
            // 
            // NewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 626);
            this.Controls.Add(this.dgvSummary);
            this.Controls.Add(this.btnConfirmbooking);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbServiceCentre);
            this.Controls.Add(this.cmbSelectService);
            this.Controls.Add(this.lblSelectTime);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblServiceCentre);
            this.Controls.Add(this.lblSelectService);
            this.Controls.Add(this.lblbookyourappointment);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.menuePanel);
            this.Controls.Add(this.NewBookingpanel);
            this.Name = "NewBookingForm";
            this.Text = "NewBookingForm";
            this.NewBookingpanel.ResumeLayout(false);
            this.NewBookingpanel.PerformLayout();
            this.menuePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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