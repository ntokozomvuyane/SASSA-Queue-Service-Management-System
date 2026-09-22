namespace Sassa_Queue_And_Service_Management_System
{
    partial class frmMyBookings
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
            lblBeneficiaryPortal = new Label();
            label1 = new Label();
            lblSassa = new Label();
            lblMyBookings = new Label();
            pnlSideBar = new Panel();
            btnLogout = new Button();
            btnMyProfile = new Button();
            btnQueueStatus = new Button();
            btnMyBooking = new Button();
            btnNewBooking = new Button();
            btnDashboard = new Button();
            pnlReschedule = new Panel();
            lblChooseAvailableSlot = new Label();
            lblRescheduleDate = new Label();
            btnRefresh = new Button();
            btnBack = new Button();
            btnConfirmReschedule = new Button();
            lblRescheduleAvailability = new Label();
            btnCloseReschedule = new Button();
            cboRescheduleTimeSlot = new ComboBox();
            dtpRescheduleDate = new DateTimePicker();
            tabControlMyBookings = new TabControl();
            tabUpcoming = new TabPage();
            btnRescheduleBooking = new Button();
            btnCancelBooking = new Button();
            dgvUpcoming = new DataGridView();
            tabPrevious = new TabPage();
            dgvPrevious = new DataGridView();
            panel1.SuspendLayout();
            pnlSideBar.SuspendLayout();
            pnlReschedule.SuspendLayout();
            tabControlMyBookings.SuspendLayout();
            tabUpcoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcoming).BeginInit();
            tabPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrevious).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblBeneficiaryPortal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblSassa);
            panel1.Controls.Add(lblMyBookings);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 81);
            panel1.TabIndex = 0;
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeneficiaryPortal.ForeColor = Color.White;
            lblBeneficiaryPortal.Location = new Point(808, 23);
            lblBeneficiaryPortal.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(107, 13);
            lblBeneficiaryPortal.TabIndex = 2;
            lblBeneficiaryPortal.Text = "Beneficiary Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 12);
            label1.TabIndex = 1;
            label1.Text = "View and manage your SASSA appointments";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(14, 13);
            lblSassa.Margin = new Padding(4, 0, 4, 0);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(87, 25);
            lblSassa.TabIndex = 1;
            lblSassa.Text = "SASSA";
            // 
            // lblMyBookings
            // 
            lblMyBookings.AutoSize = true;
            lblMyBookings.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyBookings.ForeColor = Color.White;
            lblMyBookings.Location = new Point(135, 18);
            lblMyBookings.Margin = new Padding(4, 0, 4, 0);
            lblMyBookings.Name = "lblMyBookings";
            lblMyBookings.Size = new Size(106, 18);
            lblMyBookings.TabIndex = 0;
            lblMyBookings.Text = "My Bookings";
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
            pnlSideBar.Location = new Point(0, 88);
            pnlSideBar.Margin = new Padding(4, 3, 4, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(152, 496);
            pnlSideBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(7, 235);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 39);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnSignOut_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(7, 190);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(142, 39);
            btnMyProfile.TabIndex = 11;
            btnMyProfile.Text = "Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnProfile_Click;
            // 
            // btnQueueStatus
            // 
            btnQueueStatus.Location = new Point(7, 145);
            btnQueueStatus.Name = "btnQueueStatus";
            btnQueueStatus.Size = new Size(142, 39);
            btnQueueStatus.TabIndex = 10;
            btnQueueStatus.Text = "Queue Status";
            btnQueueStatus.UseVisualStyleBackColor = true;
            btnQueueStatus.Click += btnQueueStatus_Click;
            // 
            // btnMyBooking
            // 
            btnMyBooking.Location = new Point(7, 100);
            btnMyBooking.Name = "btnMyBooking";
            btnMyBooking.Size = new Size(142, 39);
            btnMyBooking.TabIndex = 9;
            btnMyBooking.Text = "My Booking";
            btnMyBooking.UseVisualStyleBackColor = true;
            btnMyBooking.Click += btnMyBooking_Click;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Location = new Point(10, 55);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(142, 39);
            btnNewBooking.TabIndex = 7;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(3, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(149, 37);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlReschedule
            // 
            pnlReschedule.BackColor = Color.FromArgb(248, 248, 248);
            pnlReschedule.Controls.Add(lblChooseAvailableSlot);
            pnlReschedule.Controls.Add(lblRescheduleDate);
            pnlReschedule.Controls.Add(btnRefresh);
            pnlReschedule.Controls.Add(btnBack);
            pnlReschedule.Controls.Add(btnConfirmReschedule);
            pnlReschedule.Controls.Add(lblRescheduleAvailability);
            pnlReschedule.Controls.Add(btnCloseReschedule);
            pnlReschedule.Controls.Add(cboRescheduleTimeSlot);
            pnlReschedule.Controls.Add(dtpRescheduleDate);
            pnlReschedule.Location = new Point(181, 333);
            pnlReschedule.Margin = new Padding(4, 3, 4, 3);
            pnlReschedule.Name = "pnlReschedule";
            pnlReschedule.Size = new Size(653, 251);
            pnlReschedule.TabIndex = 5;
            // 
            // lblChooseAvailableSlot
            // 
            lblChooseAvailableSlot.AutoSize = true;
            lblChooseAvailableSlot.Location = new Point(20, 35);
            lblChooseAvailableSlot.Margin = new Padding(4, 0, 4, 0);
            lblChooseAvailableSlot.Name = "lblChooseAvailableSlot";
            lblChooseAvailableSlot.Size = new Size(163, 15);
            lblChooseAvailableSlot.TabIndex = 6;
            lblChooseAvailableSlot.Text = "Choose Reschedule Time Slot";
            // 
            // lblRescheduleDate
            // 
            lblRescheduleDate.AutoSize = true;
            lblRescheduleDate.Location = new Point(20, 9);
            lblRescheduleDate.Margin = new Padding(4, 0, 4, 0);
            lblRescheduleDate.Name = "lblRescheduleDate";
            lblRescheduleDate.Size = new Size(94, 15);
            lblRescheduleDate.TabIndex = 5;
            lblRescheduleDate.Text = "Reschedule Date";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(152, 159);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(149, 57);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 159);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 57);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnConfirmReschedule
            // 
            btnConfirmReschedule.Location = new Point(467, 159);
            btnConfirmReschedule.Name = "btnConfirmReschedule";
            btnConfirmReschedule.Size = new Size(173, 61);
            btnConfirmReschedule.TabIndex = 2;
            btnConfirmReschedule.Text = "Confirm Reschedule";
            btnConfirmReschedule.UseVisualStyleBackColor = true;
            btnConfirmReschedule.Click += btnConfirmReschedule_Click;
            // 
            // lblRescheduleAvailability
            // 
            lblRescheduleAvailability.AutoSize = true;
            lblRescheduleAvailability.Location = new Point(20, 81);
            lblRescheduleAvailability.Margin = new Padding(4, 0, 4, 0);
            lblRescheduleAvailability.Name = "lblRescheduleAvailability";
            lblRescheduleAvailability.Size = new Size(88, 15);
            lblRescheduleAvailability.TabIndex = 2;
            lblRescheduleAvailability.Text = "Slot Availability";
            // 
            // btnCloseReschedule
            // 
            btnCloseReschedule.Location = new Point(307, 159);
            btnCloseReschedule.Name = "btnCloseReschedule";
            btnCloseReschedule.Size = new Size(154, 59);
            btnCloseReschedule.TabIndex = 1;
            btnCloseReschedule.Text = "Close Reschedule";
            btnCloseReschedule.UseVisualStyleBackColor = true;
            btnCloseReschedule.Click += btnCloseReschedule_Click;
            // 
            // cboRescheduleTimeSlot
            // 
            cboRescheduleTimeSlot.FormattingEnabled = true;
            cboRescheduleTimeSlot.Location = new Point(208, 32);
            cboRescheduleTimeSlot.Name = "cboRescheduleTimeSlot";
            cboRescheduleTimeSlot.Size = new Size(206, 23);
            cboRescheduleTimeSlot.TabIndex = 1;
            // 
            // dtpRescheduleDate
            // 
            dtpRescheduleDate.Location = new Point(207, 3);
            dtpRescheduleDate.Name = "dtpRescheduleDate";
            dtpRescheduleDate.Size = new Size(207, 23);
            dtpRescheduleDate.TabIndex = 0;
            dtpRescheduleDate.ValueChanged += dtpRescheduleDate_ValueChanged;
            // 
            // tabControlMyBookings
            // 
            tabControlMyBookings.Controls.Add(tabUpcoming);
            tabControlMyBookings.Controls.Add(tabPrevious);
            tabControlMyBookings.Location = new Point(181, 87);
            tabControlMyBookings.Name = "tabControlMyBookings";
            tabControlMyBookings.SelectedIndex = 0;
            tabControlMyBookings.Size = new Size(653, 217);
            tabControlMyBookings.TabIndex = 7;
            // 
            // tabUpcoming
            // 
            tabUpcoming.Controls.Add(btnRescheduleBooking);
            tabUpcoming.Controls.Add(btnCancelBooking);
            tabUpcoming.Controls.Add(dgvUpcoming);
            tabUpcoming.Location = new Point(4, 24);
            tabUpcoming.Name = "tabUpcoming";
            tabUpcoming.Padding = new Padding(3);
            tabUpcoming.Size = new Size(645, 189);
            tabUpcoming.TabIndex = 0;
            tabUpcoming.Text = "Upcoming";
            tabUpcoming.UseVisualStyleBackColor = true;
            // 
            // btnRescheduleBooking
            // 
            btnRescheduleBooking.Location = new Point(476, 87);
            btnRescheduleBooking.Name = "btnRescheduleBooking";
            btnRescheduleBooking.Size = new Size(150, 68);
            btnRescheduleBooking.TabIndex = 2;
            btnRescheduleBooking.Text = "Reschedule Booking";
            btnRescheduleBooking.UseVisualStyleBackColor = true;
            btnRescheduleBooking.Click += btnRescheduleBooking_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.Location = new Point(476, 13);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(150, 68);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = true;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // dgvUpcoming
            // 
            dgvUpcoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcoming.Location = new Point(18, 11);
            dgvUpcoming.Name = "dgvUpcoming";
            dgvUpcoming.Size = new Size(392, 149);
            dgvUpcoming.TabIndex = 0;
            // 
            // tabPrevious
            // 
            tabPrevious.Controls.Add(dgvPrevious);
            tabPrevious.Location = new Point(4, 24);
            tabPrevious.Name = "tabPrevious";
            tabPrevious.Padding = new Padding(3);
            tabPrevious.Size = new Size(645, 189);
            tabPrevious.TabIndex = 1;
            tabPrevious.Text = "Previous";
            tabPrevious.UseVisualStyleBackColor = true;
            // 
            // dgvPrevious
            // 
            dgvPrevious.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrevious.Location = new Point(0, 6);
            dgvPrevious.Name = "dgvPrevious";
            dgvPrevious.Size = new Size(636, 177);
            dgvPrevious.TabIndex = 0;
            // 
            // frmMyBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 598);
            Controls.Add(tabControlMyBookings);
            Controls.Add(pnlReschedule);
            Controls.Add(pnlSideBar);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMyBookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";
            WindowState = FormWindowState.Maximized;
            Load += MyBookingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlReschedule.ResumeLayout(false);
            pnlReschedule.PerformLayout();
            tabControlMyBookings.ResumeLayout(false);
            tabUpcoming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUpcoming).EndInit();
            tabPrevious.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrevious).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSassa;
        private System.Windows.Forms.Label lblMyBookings;
        private System.Windows.Forms.Label lblBeneficiaryPortal;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlReschedule;
        private TabControl tabControlMyBookings;
        private TabPage tabUpcoming;
        private TabPage tabPrevious;
        private DataGridView dgvUpcoming;
        private Button btnRescheduleBooking;
        private Button btnCancelBooking;
        private Button btnConfirmReschedule;
        private Button btnCloseReschedule;
        private DataGridView dgvPrevious;
        private Label lblRescheduleAvailability;
        private ComboBox cboRescheduleTimeSlot;
        private DateTimePicker dtpRescheduleDate;
        private Button btnRefresh;
        private Button btnBack;
        private Label lblChooseAvailableSlot;
        private Label lblRescheduleDate;
        private Button btnNewBooking;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnMyProfile;
        private Button btnQueueStatus;
        private Button btnMyBooking;
    }
}

