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
            btnBookings = new Button();
            btnSlots = new Button();
            btnServices = new Button();
            btnReports = new Button();
            btnDashboard = new Button();
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
            pnlSideBar.Location = new Point(17, 20);
            pnlSideBar.Margin = new Padding(3, 4, 3, 4);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(177, 564);
            pnlSideBar.TabIndex = 0;
            // 
            // btnBookings
            // 
            btnBookings.Location = new Point(18, 183);
            btnBookings.Margin = new Padding(3, 4, 3, 4);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(141, 43);
            btnBookings.TabIndex = 4;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnSlots
            // 
            btnSlots.Location = new Point(18, 133);
            btnSlots.Margin = new Padding(3, 4, 3, 4);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(141, 41);
            btnSlots.TabIndex = 3;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(17, 84);
            btnServices.Margin = new Padding(3, 4, 3, 4);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(141, 41);
            btnServices.TabIndex = 2;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(18, 233);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(141, 39);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(17, 28);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(141, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentSlots
            // 
            lblAppointmentSlots.AutoSize = true;
            lblAppointmentSlots.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointmentSlots.Location = new Point(201, 27);
            lblAppointmentSlots.Name = "lblAppointmentSlots";
            lblAppointmentSlots.Size = new Size(177, 28);
            lblAppointmentSlots.TabIndex = 1;
            lblAppointmentSlots.Text = "Appointment Slots";
            // 
            // dgvAppointmentSlots
            // 
            dgvAppointmentSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentSlots.Columns.AddRange(new DataGridViewColumn[] { date, time, capacity, booked, available, fillPercentage });
            dgvAppointmentSlots.Location = new Point(225, 68);
            dgvAppointmentSlots.Margin = new Padding(3, 4, 3, 4);
            dgvAppointmentSlots.Name = "dgvAppointmentSlots";
            dgvAppointmentSlots.RowHeadersWidth = 51;
            dgvAppointmentSlots.Size = new Size(789, 95);
            dgvAppointmentSlots.TabIndex = 2;
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.Width = 125;
            // 
            // capacity
            // 
            capacity.HeaderText = "Capacity";
            capacity.MinimumWidth = 6;
            capacity.Name = "capacity";
            capacity.Width = 125;
            // 
            // booked
            // 
            booked.HeaderText = "Booked";
            booked.MinimumWidth = 6;
            booked.Name = "booked";
            booked.Width = 125;
            // 
            // available
            // 
            available.HeaderText = "Available";
            available.MinimumWidth = 6;
            available.Name = "available";
            available.Width = 125;
            // 
            // fillPercentage
            // 
            fillPercentage.HeaderText = "Fill%";
            fillPercentage.MinimumWidth = 6;
            fillPercentage.Name = "fillPercentage";
            fillPercentage.Width = 125;
            // 
            // frmAppointmentSlots
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 600);
            Controls.Add(dgvAppointmentSlots);
            Controls.Add(lblAppointmentSlots);
            Controls.Add(pnlSideBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
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