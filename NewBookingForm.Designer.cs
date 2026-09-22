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
            cboService = new ComboBox();
            cboServiceCentre = new ComboBox();
            cboTimeSlot = new ComboBox();
            dtpBookingDate = new DateTimePicker();
            btnCancel = new Button();
            btnConfirmBooking = new Button();
            dgvAppointmentSummary = new DataGridView();
            colSelectedService = new DataGridViewTextBoxColumn();
            colServiceCentre = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            lblAvailablePositions = new Label();
            btnClear = new Button();
            btnBack = new Button();
            NewBookingpanel.SuspendLayout();
            menuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSummary).BeginInit();
            SuspendLayout();
            // 
            // NewBookingpanel
            // 
            NewBookingpanel.BackColor = Color.FromArgb(26, 74, 122);
            NewBookingpanel.Controls.Add(lblbookingnewone);
            NewBookingpanel.Controls.Add(lblPortal);
            NewBookingpanel.Controls.Add(lblmanage);
            NewBookingpanel.Controls.Add(lblSassa);
            NewBookingpanel.Location = new Point(2, 3);
            NewBookingpanel.Margin = new Padding(2, 3, 2, 3);
            NewBookingpanel.Name = "NewBookingpanel";
            NewBookingpanel.Size = new Size(1055, 64);
            NewBookingpanel.TabIndex = 27;
            // 
            // lblbookingnewone
            // 
            lblbookingnewone.AutoSize = true;
            lblbookingnewone.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbookingnewone.ForeColor = SystemColors.Control;
            lblbookingnewone.Location = new Point(99, 16);
            lblbookingnewone.Margin = new Padding(2, 0, 2, 0);
            lblbookingnewone.Name = "lblbookingnewone";
            lblbookingnewone.Size = new Size(108, 18);
            lblbookingnewone.TabIndex = 20;
            lblbookingnewone.Text = "New Booking";
            // 
            // lblPortal
            // 
            lblPortal.AutoSize = true;
            lblPortal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPortal.ForeColor = SystemColors.Control;
            lblPortal.Location = new Point(843, 18);
            lblPortal.Margin = new Padding(2, 0, 2, 0);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(119, 17);
            lblPortal.TabIndex = 19;
            lblPortal.Text = "Beneficiary Portal";
            // 
            // lblmanage
            // 
            lblmanage.AutoSize = true;
            lblmanage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmanage.ForeColor = SystemColors.Control;
            lblmanage.Location = new Point(92, 45);
            lblmanage.Margin = new Padding(2, 0, 2, 0);
            lblmanage.Name = "lblmanage";
            lblmanage.Size = new Size(263, 15);
            lblmanage.TabIndex = 18;
            lblmanage.Text = "Manage your booking, profile and queue status";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = SystemColors.Control;
            lblSassa.Location = new Point(9, 18);
            lblSassa.Margin = new Padding(2, 0, 2, 0);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(77, 24);
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
            menuePanel.Location = new Point(11, 72);
            menuePanel.Margin = new Padding(2, 3, 2, 3);
            menuePanel.Name = "menuePanel";
            menuePanel.Size = new Size(160, 507);
            menuePanel.TabIndex = 28;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(14, 305);
            btnLogout.Margin = new Padding(2, 3, 2, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 38);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(14, 252);
            btnProfile.Margin = new Padding(2, 3, 2, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(126, 38);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnQueueStatus
            // 
            btnQueueStatus.Location = new Point(14, 197);
            btnQueueStatus.Margin = new Padding(2, 3, 2, 3);
            btnQueueStatus.Name = "btnQueueStatus";
            btnQueueStatus.Size = new Size(126, 38);
            btnQueueStatus.TabIndex = 3;
            btnQueueStatus.Text = "Queue Status";
            btnQueueStatus.UseVisualStyleBackColor = true;
            btnQueueStatus.Click += btnQueueStatus_Click;
            // 
            // btnMyBooking
            // 
            btnMyBooking.Location = new Point(14, 145);
            btnMyBooking.Margin = new Padding(2, 3, 2, 3);
            btnMyBooking.Name = "btnMyBooking";
            btnMyBooking.Size = new Size(126, 38);
            btnMyBooking.TabIndex = 2;
            btnMyBooking.Text = "My Booking";
            btnMyBooking.UseVisualStyleBackColor = true;
            btnMyBooking.Click += btnMyBooking_Click;
            // 
            // btnNewBooking
            // 
            btnNewBooking.BackColor = Color.FromArgb(26, 74, 122);
            btnNewBooking.ForeColor = SystemColors.Control;
            btnNewBooking.Location = new Point(14, 97);
            btnNewBooking.Margin = new Padding(2, 3, 2, 3);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(126, 38);
            btnNewBooking.TabIndex = 1;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(14, 44);
            btnDashboard.Margin = new Padding(2, 3, 2, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(126, 38);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooking.Location = new Point(474, 93);
            lblBooking.Margin = new Padding(2, 0, 2, 0);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(129, 18);
            lblBooking.TabIndex = 29;
            lblBooking.Text = "NEW BOOKING";
            // 
            // lblbookyourappointment
            // 
            lblbookyourappointment.AutoSize = true;
            lblbookyourappointment.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbookyourappointment.Location = new Point(425, 123);
            lblbookyourappointment.Margin = new Padding(2, 0, 2, 0);
            lblbookyourappointment.Name = "lblbookyourappointment";
            lblbookyourappointment.Size = new Size(241, 18);
            lblbookyourappointment.TabIndex = 30;
            lblbookyourappointment.Text = "Book your SASSA appointment";
            // 
            // lblSelectService
            // 
            lblSelectService.AutoSize = true;
            lblSelectService.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectService.Location = new Point(211, 177);
            lblSelectService.Margin = new Padding(2, 0, 2, 0);
            lblSelectService.Name = "lblSelectService";
            lblSelectService.Size = new Size(96, 17);
            lblSelectService.TabIndex = 31;
            lblSelectService.Text = "Select service";
            // 
            // lblServiceCentre
            // 
            lblServiceCentre.AutoSize = true;
            lblServiceCentre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceCentre.Location = new Point(211, 269);
            lblServiceCentre.Margin = new Padding(2, 0, 2, 0);
            lblServiceCentre.Name = "lblServiceCentre";
            lblServiceCentre.Size = new Size(140, 17);
            lblServiceCentre.TabIndex = 32;
            lblServiceCentre.Text = "Select service centre";
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectDate.Location = new Point(211, 358);
            lblSelectDate.Margin = new Padding(2, 0, 2, 0);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(81, 17);
            lblSelectDate.TabIndex = 33;
            lblSelectDate.Text = "Select Date";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(657, 169);
            lblSummary.Margin = new Padding(2, 0, 2, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(154, 17);
            lblSummary.TabIndex = 34;
            lblSummary.Text = " Appointment Summary";
            // 
            // lblSelectTime
            // 
            lblSelectTime.AutoSize = true;
            lblSelectTime.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectTime.Location = new Point(211, 436);
            lblSelectTime.Margin = new Padding(2, 0, 2, 0);
            lblSelectTime.Name = "lblSelectTime";
            lblSelectTime.Size = new Size(82, 17);
            lblSelectTime.TabIndex = 35;
            lblSelectTime.Text = "Select Time";
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Items.AddRange(new object[] { "New Grant Application", "Existing Grant Enquiry", "Grant Information Update", "Payment Enquiry", "Document Submission", "General Assistance" });
            cboService.Location = new Point(215, 218);
            cboService.Margin = new Padding(2, 3, 2, 3);
            cboService.Name = "cboService";
            cboService.Size = new Size(314, 23);
            cboService.TabIndex = 36;
            cboService.Text = "Select a service";
            cboService.SelectedIndexChanged += cboService_SelectedIndexChanged;
            // 
            // cboServiceCentre
            // 
            cboServiceCentre.FormattingEnabled = true;
            cboServiceCentre.Items.AddRange(new object[] { "Johannesburg Central SASSA Centre", "Soweto SASSA Centre", "Alexandra SASSA Centre ", "Roodepoort SASSA Centre " });
            cboServiceCentre.Location = new Point(215, 313);
            cboServiceCentre.Margin = new Padding(2, 3, 2, 3);
            cboServiceCentre.Name = "cboServiceCentre";
            cboServiceCentre.Size = new Size(314, 23);
            cboServiceCentre.TabIndex = 37;
            cboServiceCentre.Text = "Select a service centre";
            cboServiceCentre.SelectedIndexChanged += cboServiceCentre_SelectedIndexChanged;
            // 
            // cboTimeSlot
            // 
            cboTimeSlot.FormattingEnabled = true;
            cboTimeSlot.Items.AddRange(new object[] { "08:00 - 08:30", "08:30 - 09:00", "09:00 - 09:30", "09:30 - 10:00", "10:00 - 10:30", "10:30 - 11:00" });
            cboTimeSlot.Location = new Point(215, 473);
            cboTimeSlot.Margin = new Padding(2, 3, 2, 3);
            cboTimeSlot.Name = "cboTimeSlot";
            cboTimeSlot.Size = new Size(259, 23);
            cboTimeSlot.TabIndex = 39;
            cboTimeSlot.Text = "Available Time Slots";
            cboTimeSlot.SelectedIndexChanged += cboTimeSlot_SelectedIndexChanged;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Location = new Point(215, 394);
            dtpBookingDate.Margin = new Padding(2, 3, 2, 3);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(259, 23);
            dtpBookingDate.TabIndex = 40;
            dtpBookingDate.ValueChanged += dtpBookingDate_ValueChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(591, 502);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 46);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.Location = new Point(840, 502);
            btnConfirmBooking.Margin = new Padding(2, 3, 2, 3);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(201, 46);
            btnConfirmBooking.TabIndex = 42;
            btnConfirmBooking.Text = "Confirm Booking";
            btnConfirmBooking.UseVisualStyleBackColor = true;
            btnConfirmBooking.Click += btnConfirmBooking_Click;
            // 
            // dgvAppointmentSummary
            // 
            dgvAppointmentSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointmentSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentSummary.Columns.AddRange(new DataGridViewColumn[] { colSelectedService, colServiceCentre, colDate, colTime });
            dgvAppointmentSummary.Location = new Point(558, 195);
            dgvAppointmentSummary.Margin = new Padding(2, 3, 2, 3);
            dgvAppointmentSummary.Name = "dgvAppointmentSummary";
            dgvAppointmentSummary.RowHeadersWidth = 51;
            dgvAppointmentSummary.RowTemplate.Height = 24;
            dgvAppointmentSummary.Size = new Size(483, 274);
            dgvAppointmentSummary.TabIndex = 43;
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
            // lblAvailablePositions
            // 
            lblAvailablePositions.AutoSize = true;
            lblAvailablePositions.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailablePositions.Location = new Point(215, 504);
            lblAvailablePositions.Margin = new Padding(2, 0, 2, 0);
            lblAvailablePositions.Name = "lblAvailablePositions";
            lblAvailablePositions.Size = new Size(126, 17);
            lblAvailablePositions.TabIndex = 44;
            lblAvailablePositions.Text = "Available Positions";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(356, 502);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(198, 46);
            btnClear.TabIndex = 45;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(190, 79);
            btnBack.Margin = new Padding(2, 3, 2, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(151, 46);
            btnBack.TabIndex = 46;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 544);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(lblAvailablePositions);
            Controls.Add(dgvAppointmentSummary);
            Controls.Add(btnConfirmBooking);
            Controls.Add(btnCancel);
            Controls.Add(dtpBookingDate);
            Controls.Add(cboTimeSlot);
            Controls.Add(cboServiceCentre);
            Controls.Add(cboService);
            Controls.Add(lblSelectTime);
            Controls.Add(lblSummary);
            Controls.Add(lblSelectDate);
            Controls.Add(lblServiceCentre);
            Controls.Add(lblSelectService);
            Controls.Add(lblbookyourappointment);
            Controls.Add(lblBooking);
            Controls.Add(menuePanel);
            Controls.Add(NewBookingpanel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "NewBookingForm";
            Text = "NewBookingForm";
            Load += NewBookingForm_Load;
            NewBookingpanel.ResumeLayout(false);
            NewBookingpanel.PerformLayout();
            menuePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSummary).EndInit();
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
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.ComboBox cboServiceCentre;
        private System.Windows.Forms.ComboBox cboTimeSlot;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.DataGridView dgvAppointmentSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelectedService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceCentre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private Label lblAvailablePositions;
        private Button btnClear;
        private Button btnBack;
    }
}