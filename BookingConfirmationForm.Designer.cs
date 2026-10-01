namespace SASSAQueueManagementSystem
{
    partial class BookingConfirmationForm
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
            lblHeading = new Label();
            btnCreateAnother = new Button();
            lblServiceCaption = new Label();
            lblReferenceCaption = new Label();
            lblInstruction = new Label();
            lblReferenceNumber = new Label();
            lblAppointmentDate = new Label();
            lblDateCaption = new Label();
            lblCentreName = new Label();
            lblCentreCaption = new Label();
            lblServiceName = new Label();
            lblBookingStatus = new Label();
            lblStatusCaption = new Label();
            lblAppointmentTime = new Label();
            lblTimeCaption = new Label();
            btnDone = new Button();
            pnlBookingConfirmation = new Panel();
            pnlBookingConfirmationForm = new Panel();
            lblStaffRole = new Label();
            lblStaffName = new Label();
            lblSystemName = new Label();
            lblSystemSubtitle = new Label();
            pnlBookingConfirmation.SuspendLayout();
            pnlBookingConfirmationForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(2, 1);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(111, 15);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Booking Confirmed";
            // 
            // btnCreateAnother
            // 
            btnCreateAnother.BackColor = Color.FromArgb(0, 51, 102);
            btnCreateAnother.Location = new Point(195, 336);
            btnCreateAnother.Name = "btnCreateAnother";
            btnCreateAnother.Size = new Size(344, 53);
            btnCreateAnother.TabIndex = 1;
            btnCreateAnother.Text = "Create Another";
            btnCreateAnother.UseVisualStyleBackColor = false;
            btnCreateAnother.Click += btnCreateAnother_Click;
            // 
            // lblServiceCaption
            // 
            lblServiceCaption.AutoSize = true;
            lblServiceCaption.Location = new Point(2, 85);
            lblServiceCaption.Name = "lblServiceCaption";
            lblServiceCaption.Size = new Size(44, 15);
            lblServiceCaption.TabIndex = 2;
            lblServiceCaption.Text = "Service";
            // 
            // lblReferenceCaption
            // 
            lblReferenceCaption.AutoSize = true;
            lblReferenceCaption.Location = new Point(2, 53);
            lblReferenceCaption.Name = "lblReferenceCaption";
            lblReferenceCaption.Size = new Size(104, 15);
            lblReferenceCaption.TabIndex = 3;
            lblReferenceCaption.Text = "Reference number";
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(2, 25);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(224, 15);
            lblInstruction.TabIndex = 4;
            lblInstruction.Text = "Keep your reference number for check-in";
            // 
            // lblReferenceNumber
            // 
            lblReferenceNumber.AutoSize = true;
            lblReferenceNumber.Location = new Point(298, 53);
            lblReferenceNumber.Name = "lblReferenceNumber";
            lblReferenceNumber.Size = new Size(113, 15);
            lblReferenceNumber.TabIndex = 5;
            lblReferenceNumber.Text = "Generated reference";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(298, 149);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(78, 15);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "Booking Date";
            // 
            // lblDateCaption
            // 
            lblDateCaption.AutoSize = true;
            lblDateCaption.Location = new Point(5, 149);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(102, 15);
            lblDateCaption.TabIndex = 7;
            lblDateCaption.Text = "AppointmentDate";
            // 
            // lblCentreName
            // 
            lblCentreName.AutoSize = true;
            lblCentreName.Location = new Point(298, 119);
            lblCentreName.Name = "lblCentreName";
            lblCentreName.Size = new Size(89, 15);
            lblCentreName.TabIndex = 8;
            lblCentreName.Text = "Selected Centre";
            // 
            // lblCentreCaption
            // 
            lblCentreCaption.AutoSize = true;
            lblCentreCaption.Location = new Point(2, 119);
            lblCentreCaption.Name = "lblCentreCaption";
            lblCentreCaption.Size = new Size(82, 15);
            lblCentreCaption.TabIndex = 9;
            lblCentreCaption.Text = "Centre Service";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new Point(298, 85);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(90, 15);
            lblServiceName.TabIndex = 10;
            lblServiceName.Text = "Selected service";
            // 
            // lblBookingStatus
            // 
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.Location = new Point(298, 208);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(47, 15);
            lblBookingStatus.TabIndex = 11;
            lblBookingStatus.Text = "Booked";
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Location = new Point(5, 208);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(86, 15);
            lblStatusCaption.TabIndex = 12;
            lblStatusCaption.Text = "Booking Status";
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new Point(298, 180);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(81, 15);
            lblAppointmentTime.TabIndex = 13;
            lblAppointmentTime.Text = "Booking Time";
            // 
            // lblTimeCaption
            // 
            lblTimeCaption.AutoSize = true;
            lblTimeCaption.Location = new Point(5, 180);
            lblTimeCaption.Name = "lblTimeCaption";
            lblTimeCaption.Size = new Size(108, 15);
            lblTimeCaption.TabIndex = 14;
            lblTimeCaption.Text = "Appointment Time";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(0, 51, 102);
            btnDone.Location = new Point(195, 395);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(344, 53);
            btnDone.TabIndex = 15;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // pnlBookingConfirmation
            // 
            pnlBookingConfirmation.BackColor = Color.FromArgb(248, 249, 250);
            pnlBookingConfirmation.BorderStyle = BorderStyle.Fixed3D;
            pnlBookingConfirmation.Controls.Add(lblTimeCaption);
            pnlBookingConfirmation.Controls.Add(lblAppointmentTime);
            pnlBookingConfirmation.Controls.Add(lblBookingStatus);
            pnlBookingConfirmation.Controls.Add(lblStatusCaption);
            pnlBookingConfirmation.Controls.Add(lblServiceName);
            pnlBookingConfirmation.Controls.Add(lblCentreCaption);
            pnlBookingConfirmation.Controls.Add(lblCentreName);
            pnlBookingConfirmation.Controls.Add(lblDateCaption);
            pnlBookingConfirmation.Controls.Add(lblAppointmentDate);
            pnlBookingConfirmation.Controls.Add(lblReferenceNumber);
            pnlBookingConfirmation.Controls.Add(lblInstruction);
            pnlBookingConfirmation.Controls.Add(lblReferenceCaption);
            pnlBookingConfirmation.Controls.Add(lblServiceCaption);
            pnlBookingConfirmation.Controls.Add(lblHeading);
            pnlBookingConfirmation.Location = new Point(98, 66);
            pnlBookingConfirmation.Name = "pnlBookingConfirmation";
            pnlBookingConfirmation.Size = new Size(545, 264);
            pnlBookingConfirmation.TabIndex = 16;
            // 
            // pnlBookingConfirmationForm
            // 
            pnlBookingConfirmationForm.BackColor = Color.FromArgb(0, 51, 102);
            pnlBookingConfirmationForm.BorderStyle = BorderStyle.Fixed3D;
            pnlBookingConfirmationForm.Controls.Add(lblStaffRole);
            pnlBookingConfirmationForm.Controls.Add(lblStaffName);
            pnlBookingConfirmationForm.Controls.Add(lblSystemName);
            pnlBookingConfirmationForm.Controls.Add(lblSystemSubtitle);
            pnlBookingConfirmationForm.Dock = DockStyle.Top;
            pnlBookingConfirmationForm.Location = new Point(0, 0);
            pnlBookingConfirmationForm.Margin = new Padding(3, 2, 3, 2);
            pnlBookingConfirmationForm.Name = "pnlBookingConfirmationForm";
            pnlBookingConfirmationForm.Size = new Size(843, 49);
            pnlBookingConfirmationForm.TabIndex = 17;
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
            lblSystemSubtitle.Size = new Size(81, 15);
            lblSystemSubtitle.TabIndex = 2;
            lblSystemSubtitle.Text = "Staff Console";
            // 
            // BookingConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 450);
            Controls.Add(pnlBookingConfirmationForm);
            Controls.Add(pnlBookingConfirmation);
            Controls.Add(btnDone);
            Controls.Add(btnCreateAnother);
            Name = "BookingConfirmationForm";
            Text = "BookingConfirmationForm";
            Load += BookingConfirmationForm_Load;
            pnlBookingConfirmation.ResumeLayout(false);
            pnlBookingConfirmation.PerformLayout();
            pnlBookingConfirmationForm.ResumeLayout(false);
            pnlBookingConfirmationForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeading;
        private Button btnCreateAnother;
        private Label lblServiceCaption;
        private Label lblReferenceCaption;
        private Label lblInstruction;
        private Label lblReferenceNumber;
        private Label lblAppointmentDate;
        private Label lblDateCaption;
        private Label lblCentreName;
        private Label lblCentreCaption;
        private Label lblServiceName;
        private Label lblBookingStatus;
        private Label lblStatusCaption;
        private Label lblAppointmentTime;
        private Label lblTimeCaption;
        private Button btnDone;
        private Panel pnlBookingConfirmation;
        private Panel pnlBookingConfirmationForm;
        private Label lblStaffRole;
        private Label lblStaffName;
        private Label lblSystemName;
        private Label lblSystemSubtitle;
    }
}