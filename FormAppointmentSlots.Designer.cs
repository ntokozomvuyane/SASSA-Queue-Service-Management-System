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
            lblAppointmentSlots = new Label();
            dgvAppointmentSlots = new DataGridView();
            date = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            booked = new DataGridViewTextBoxColumn();
            available = new DataGridViewTextBoxColumn();
            fillPercentage = new DataGridViewTextBoxColumn();
            btnLogout = new Button();
            btnAddSlots = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).BeginInit();
            SuspendLayout();
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
            dgvAppointmentSlots.Size = new Size(613, 322);
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
            // btnLogout
            // 
            btnLogout.Location = new Point(641, 407);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(128, 31);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAddSlots
            // 
            btnAddSlots.Location = new Point(651, 46);
            btnAddSlots.Name = "btnAddSlots";
            btnAddSlots.Size = new Size(118, 31);
            btnAddSlots.TabIndex = 4;
            btnAddSlots.Text = "+Add Slots";
            btnAddSlots.UseVisualStyleBackColor = true;
            // 
            // frmAppointmentSlots
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnAddSlots);
            Controls.Add(dgvAppointmentSlots);
            Controls.Add(lblAppointmentSlots);
            Name = "frmAppointmentSlots";
            Text = "Appointment Slots";
            ((System.ComponentModel.ISupportInitialize)dgvAppointmentSlots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAppointmentSlots;
        private DataGridView dgvAppointmentSlots;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn capacity;
        private DataGridViewTextBoxColumn booked;
        private DataGridViewTextBoxColumn available;
        private DataGridViewTextBoxColumn fillPercentage;
        private Button btnLogout;
        private Button btnAddSlots;
    }
}