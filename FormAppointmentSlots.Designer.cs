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
            pnlAppointmentSlots = new Panel();
            lblStaffRole = new Label();
            lblStaffName = new Label();
            lblSystemName = new Label();
            lblSystemSubtitle = new Label();
            btnAddSlots = new Button();
            btnLogout = new Button();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).BeginInit();
            pnlAppointmentSlots.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(0, 51, 102);
            pnlSideBar.BorderStyle = BorderStyle.Fixed3D;
            pnlSideBar.Controls.Add(btnBookings);
            pnlSideBar.Controls.Add(btnSlots);
            pnlSideBar.Controls.Add(btnServices);
            pnlSideBar.Controls.Add(btnReports);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Location = new Point(5, 54);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(145, 384);
            pnlSideBar.TabIndex = 0;
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
            // btnSlots
            // 
            btnSlots.Location = new Point(14, 100);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(109, 31);
            btnSlots.TabIndex = 3;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = true;
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
            // btnReports
            // 
            btnReports.Location = new Point(14, 175);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(109, 29);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
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
            // lblAppointmentSlots
            // 
            lblAppointmentSlots.AutoSize = true;
            lblAppointmentSlots.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppointmentSlots.Location = new Point(156, 54);
            lblAppointmentSlots.Name = "lblAppointmentSlots";
            lblAppointmentSlots.Size = new Size(139, 21);
            lblAppointmentSlots.TabIndex = 1;
            lblAppointmentSlots.Text = "Appointment Slots";
            // 
            // dgvAppointmentSlots
            // 
            dgvAppointmentSlots.BackgroundColor = Color.FromArgb(248, 249, 250);
            dgvAppointmentSlots.BorderStyle = BorderStyle.Fixed3D;
            dgvAppointmentSlots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointmentSlots.Columns.AddRange(new DataGridViewColumn[] { date, time, capacity, booked, available, fillPercentage });
            dgvAppointmentSlots.Location = new Point(156, 79);
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
            // pnlAppointmentSlots
            // 
            pnlAppointmentSlots.BackColor = Color.FromArgb(0, 51, 102);
            pnlAppointmentSlots.BorderStyle = BorderStyle.Fixed3D;
            pnlAppointmentSlots.Controls.Add(btnLogout);
            pnlAppointmentSlots.Controls.Add(btnAddSlots);
            pnlAppointmentSlots.Controls.Add(lblStaffRole);
            pnlAppointmentSlots.Controls.Add(lblStaffName);
            pnlAppointmentSlots.Controls.Add(lblSystemName);
            pnlAppointmentSlots.Controls.Add(lblSystemSubtitle);
            pnlAppointmentSlots.Dock = DockStyle.Top;
            pnlAppointmentSlots.Location = new Point(0, 0);
            pnlAppointmentSlots.Margin = new Padding(3, 2, 3, 2);
            pnlAppointmentSlots.Name = "pnlAppointmentSlots";
            pnlAppointmentSlots.Size = new Size(800, 49);
            pnlAppointmentSlots.TabIndex = 18;
            // 
            // lblStaffRole
            // 
            lblStaffRole.AutoSize = true;
            lblStaffRole.Location = new Point(886, 26);
            lblStaffRole.Name = "lblStaffRole";
            lblStaffRole.Size = new Size(83, 15);
            lblStaffRole.TabIndex = 2;
            lblStaffRole.Text = "Service Officer";
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(886, 10);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(87, 15);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Officer Bhengu";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(3, 7);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(55, 20);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "SASSA";
            // 
            // lblSystemSubtitle
            // 
            lblSystemSubtitle.AutoSize = true;
            lblSystemSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSystemSubtitle.ForeColor = Color.White;
            lblSystemSubtitle.Location = new Point(3, 26);
            lblSystemSubtitle.Name = "lblSystemSubtitle";
            lblSystemSubtitle.Size = new Size(89, 15);
            lblSystemSubtitle.TabIndex = 2;
            lblSystemSubtitle.Text = "Admin Console";
            // 
            // btnAddSlots
            // 
            btnAddSlots.Location = new Point(668, 7);
            btnAddSlots.Name = "btnAddSlots";
            btnAddSlots.Size = new Size(118, 31);
            btnAddSlots.TabIndex = 4;
            btnAddSlots.Text = "+Add Slots";
            btnAddSlots.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(525, 7);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(128, 31);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmAppointmentSlots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAppointmentSlots);
            Controls.Add(dgvAppointmentSlots);
            Controls.Add(lblAppointmentSlots);
            Controls.Add(pnlSideBar);
            Name = "frmAppointmentSlots";
            Text = "Appointment Slots";
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).EndInit();
            pnlAppointmentSlots.ResumeLayout(false);
            pnlAppointmentSlots.PerformLayout();
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
        private Panel pnlAppointmentSlots;
        private Label lblStaffRole;
        private Label lblStaffName;
        private Label lblSystemName;
        private Label lblSystemSubtitle;
        private Button btnLogout;
        private Button btnAddSlots;
    }
}