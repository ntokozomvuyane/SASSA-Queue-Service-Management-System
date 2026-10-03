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
            pnlReschedule = new Panel();
            btnConfirmReschedule = new Button();
            btnCloseReschedule = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            lblChooseAvailableSlot = new Label();
            lblRescheduleDate = new Label();
            lblRescheduleAvailability = new Label();
            cboRescheduleTimeSlot = new ComboBox();
            dtpRescheduleDate = new DateTimePicker();
            tabControlMyBookings = new TabControl();
            tabUpcoming = new TabPage();
            btnRescheduleBooking = new Button();
            btnCancelBooking = new Button();
            dgvUpcoming = new DataGridView();
            tabPrevious = new TabPage();
            dgvPrevious = new DataGridView();
            pnlReschedule.SuspendLayout();
            tabControlMyBookings.SuspendLayout();
            tabUpcoming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpcoming).BeginInit();
            tabPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrevious).BeginInit();
            SuspendLayout();
            // 
            // pnlReschedule
            // 
            pnlReschedule.BackColor = Color.FromArgb(248, 248, 248);
            pnlReschedule.BorderStyle = BorderStyle.Fixed3D;
            pnlReschedule.Controls.Add(btnConfirmReschedule);
            pnlReschedule.Controls.Add(btnCloseReschedule);
            pnlReschedule.Controls.Add(btnRefresh);
            pnlReschedule.Controls.Add(btnBack);
            pnlReschedule.Controls.Add(lblChooseAvailableSlot);
            pnlReschedule.Controls.Add(lblRescheduleDate);
            pnlReschedule.Controls.Add(lblRescheduleAvailability);
            pnlReschedule.Controls.Add(cboRescheduleTimeSlot);
            pnlReschedule.Controls.Add(dtpRescheduleDate);
            pnlReschedule.Location = new Point(181, 333);
            pnlReschedule.Margin = new Padding(4, 3, 4, 3);
            pnlReschedule.Name = "pnlReschedule";
            pnlReschedule.Size = new Size(653, 251);
            pnlReschedule.TabIndex = 5;
            // 
            // btnConfirmReschedule
            // 
            btnConfirmReschedule.BackColor = Color.FromArgb(0, 51, 102);
            btnConfirmReschedule.ForeColor = SystemColors.Control;
            btnConfirmReschedule.Location = new Point(485, 174);
            btnConfirmReschedule.Name = "btnConfirmReschedule";
            btnConfirmReschedule.Size = new Size(155, 59);
            btnConfirmReschedule.TabIndex = 50;
            btnConfirmReschedule.Text = "Confirm Reschedule";
            btnConfirmReschedule.UseVisualStyleBackColor = false;
            btnConfirmReschedule.Click += btnConfirmReschedule_Click;
            // 
            // btnCloseReschedule
            // 
            btnCloseReschedule.BackColor = Color.FromArgb(0, 51, 102);
            btnCloseReschedule.ForeColor = SystemColors.Control;
            btnCloseReschedule.Location = new Point(325, 174);
            btnCloseReschedule.Name = "btnCloseReschedule";
            btnCloseReschedule.Size = new Size(155, 59);
            btnCloseReschedule.TabIndex = 49;
            btnCloseReschedule.Text = "Close Reschedule";
            btnCloseReschedule.UseVisualStyleBackColor = false;
            btnCloseReschedule.Click += btnCloseReschedule_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 51, 102);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(164, 174);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(155, 59);
            btnRefresh.TabIndex = 48;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 51, 102);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(3, 174);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 59);
            btnBack.TabIndex = 47;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            tabUpcoming.BorderStyle = BorderStyle.Fixed3D;
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
            btnRescheduleBooking.BackColor = Color.FromArgb(0, 51, 102);
            btnRescheduleBooking.ForeColor = Color.White;
            btnRescheduleBooking.Location = new Point(476, 87);
            btnRescheduleBooking.Name = "btnRescheduleBooking";
            btnRescheduleBooking.Size = new Size(150, 68);
            btnRescheduleBooking.TabIndex = 2;
            btnRescheduleBooking.Text = "Reschedule Booking";
            btnRescheduleBooking.UseVisualStyleBackColor = false;
            btnRescheduleBooking.Click += btnRescheduleBooking_Click;
            // 
            // btnCancelBooking
            // 
            btnCancelBooking.BackColor = Color.FromArgb(0, 51, 102);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(476, 13);
            btnCancelBooking.Name = "btnCancelBooking";
            btnCancelBooking.Size = new Size(150, 68);
            btnCancelBooking.TabIndex = 1;
            btnCancelBooking.Text = "Cancel Booking";
            btnCancelBooking.UseVisualStyleBackColor = false;
            btnCancelBooking.Click += btnCancelBooking_Click;
            // 
            // dgvUpcoming
            // 
            dgvUpcoming.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvUpcoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpcoming.Location = new Point(18, 11);
            dgvUpcoming.Name = "dgvUpcoming";
            dgvUpcoming.Size = new Size(392, 149);
            dgvUpcoming.TabIndex = 0;
            // 
            // tabPrevious
            // 
            tabPrevious.BorderStyle = BorderStyle.Fixed3D;
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
            dgvPrevious.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvPrevious.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrevious.Location = new Point(0, 1);
            dgvPrevious.Name = "dgvPrevious";
            dgvPrevious.Size = new Size(636, 182);
            dgvPrevious.TabIndex = 0;
            // 
            // frmMyBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 598);
            Controls.Add(tabControlMyBookings);
            Controls.Add(pnlReschedule);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMyBookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";
            WindowState = FormWindowState.Maximized;
            Load += MyBookingsForm_Load;
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
        private System.Windows.Forms.Panel pnlReschedule;
        private TabControl tabControlMyBookings;
        private TabPage tabUpcoming;
        private TabPage tabPrevious;
        private DataGridView dgvUpcoming;
        private Button btnRescheduleBooking;
        private Button btnCancelBooking;
        private DataGridView dgvPrevious;
        private Label lblRescheduleAvailability;
        private ComboBox cboRescheduleTimeSlot;
        private DateTimePicker dtpRescheduleDate;
        private Label lblChooseAvailableSlot;
        private Label lblRescheduleDate;
        private Button btnConfirmReschedule;
        private Button btnCloseReschedule;
        private Button btnRefresh;
        private Button btnBack;
    }
}

