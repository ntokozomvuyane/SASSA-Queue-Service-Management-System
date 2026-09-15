namespace SASSAQueueManagementSystem
{
    partial class frmAppointmentSlots
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
            btnDashboard = new Button();
            btnReports = new Button();
            btnServices = new Button();
            btnSlots = new Button();
            btnBookings = new Button();
            lblAppointmentSlots = new Label();
            dgvAppointmentSlots = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            booked = new DataGridViewTextBoxColumn();
            available = new DataGridViewTextBoxColumn();
            fillPercentage = new DataGridViewTextBoxColumn();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.Controls.Add(btnBookings);
            pnlSideBar.Controls.Add(btnSlots);
            pnlSideBar.Controls.Add(btnServices);
            pnlSideBar.Controls.Add(btnReports);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Location = new Point(13, 15);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(137, 423);
            pnlSideBar.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 21);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(109, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(14, 175);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(109, 29);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(13, 63);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(109, 31);
            btnServices.TabIndex = 2;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnSlots
            // 
            btnSlots.Location = new Point(14, 100);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(109, 31);
            btnSlots.TabIndex = 3;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(14, 137);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(109, 32);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentSlots
            // 
            lblAppointmentSlots.AutoSize = true;
            lblAppointmentSlots.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointmentSlots.Location = new Point(157, 20);
            lblAppointmentSlots.Name = "lblAppointmentSlots";
            lblAppointmentSlots.Size = new Size(139, 21);
            lblAppointmentSlots.TabIndex = 1;
            lblAppointmentSlots.Text = "Appointment Slots";
            // 
            // dgvAppointmentSlots
            // 
            dgvAppointmentSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentSlots.Columns.AddRange(new DataGridViewColumn[] { date, time, capacity, booked, available, fillPercentage });
            dgvAppointmentSlots.Location = new Point(175, 51);
            dgvAppointmentSlots.Name = "dgvAppointmentSlots";
            dgvAppointmentSlots.Size = new Size(613, 71);
            dgvAppointmentSlots.TabIndex = 2;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.Name = "time";
            // 
            // capacity
            // 
            capacity.HeaderText = "Capacity";
            capacity.Name = "capacity";
            // 
            // booked
            // 
            booked.HeaderText = "Booked";
            booked.Name = "booked";
            // 
            // available
            // 
            available.HeaderText = "Available";
            available.Name = "available";
            // 
            // fillPercentage
            // 
            fillPercentage.HeaderText = "Fill%";
            fillPercentage.Name = "fillPercentage";
            // 
            // frmAppointmentSlots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAppointmentSlots);
            Controls.Add(lblAppointmentSlots);
            Controls.Add(pnlSideBar);
            Name = "frmAppointmentSlots";
            Text = "Appointment Slots";
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideBar;
        private Button btnBookings;
        private Button btnSlots;
        private Button btnServices;
        private Button btnReports;
        private Button btnDashboard;
        private Label lblAppointmentSlots;
        private DataGridView dgvAppointmentSlots;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn capacity;
        private DataGridViewTextBoxColumn booked;
        private DataGridViewTextBoxColumn available;
        private DataGridViewTextBoxColumn fillPercentage;
    }
}