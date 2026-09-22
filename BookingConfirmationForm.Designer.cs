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
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(15, 12);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(111, 15);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Booking Confirmed";
            // 
            // btnCreateAnother
            // 
            btnCreateAnother.Location = new Point(18, 253);
            btnCreateAnother.Name = "btnCreateAnother";
            btnCreateAnother.Size = new Size(344, 53);
            btnCreateAnother.TabIndex = 1;
            btnCreateAnother.Text = "Create Another";
            btnCreateAnother.UseVisualStyleBackColor = true;
            btnCreateAnother.Click += btnCreateAnother_Click;
            // 
            // lblServiceCaption
            // 
            lblServiceCaption.AutoSize = true;
            lblServiceCaption.Location = new Point(15, 96);
            lblServiceCaption.Name = "lblServiceCaption";
            lblServiceCaption.Size = new Size(44, 15);
            lblServiceCaption.TabIndex = 2;
            lblServiceCaption.Text = "Service";
            // 
            // lblReferenceCaption
            // 
            lblReferenceCaption.AutoSize = true;
            lblReferenceCaption.Location = new Point(15, 64);
            lblReferenceCaption.Name = "lblReferenceCaption";
            lblReferenceCaption.Size = new Size(104, 15);
            lblReferenceCaption.TabIndex = 3;
            lblReferenceCaption.Text = "Reference number";
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(15, 36);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(224, 15);
            lblInstruction.TabIndex = 4;
            lblInstruction.Text = "Keep your reference number for check-in";
            // 
            // lblReferenceNumber
            // 
            lblReferenceNumber.AutoSize = true;
            lblReferenceNumber.Location = new Point(249, 64);
            lblReferenceNumber.Name = "lblReferenceNumber";
            lblReferenceNumber.Size = new Size(113, 15);
            lblReferenceNumber.TabIndex = 5;
            lblReferenceNumber.Text = "Generated reference";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(249, 160);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(78, 15);
            lblAppointmentDate.TabIndex = 6;
            lblAppointmentDate.Text = "Booking Date";
            // 
            // lblDateCaption
            // 
            lblDateCaption.AutoSize = true;
            lblDateCaption.Location = new Point(18, 160);
            lblDateCaption.Name = "lblDateCaption";
            lblDateCaption.Size = new Size(102, 15);
            lblDateCaption.TabIndex = 7;
            lblDateCaption.Text = "AppointmentDate";
            // 
            // lblCentreName
            // 
            lblCentreName.AutoSize = true;
            lblCentreName.Location = new Point(250, 130);
            lblCentreName.Name = "lblCentreName";
            lblCentreName.Size = new Size(89, 15);
            lblCentreName.TabIndex = 8;
            lblCentreName.Text = "Selected Centre";
            // 
            // lblCentreCaption
            // 
            lblCentreCaption.AutoSize = true;
            lblCentreCaption.Location = new Point(15, 130);
            lblCentreCaption.Name = "lblCentreCaption";
            lblCentreCaption.Size = new Size(82, 15);
            lblCentreCaption.TabIndex = 9;
            lblCentreCaption.Text = "Centre Service";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Location = new Point(249, 96);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(90, 15);
            lblServiceName.TabIndex = 10;
            lblServiceName.Text = "Selected service";
            // 
            // lblBookingStatus
            // 
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.Location = new Point(249, 225);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(47, 15);
            lblBookingStatus.TabIndex = 11;
            lblBookingStatus.Text = "Booked";
            // 
            // lblStatusCaption
            // 
            lblStatusCaption.AutoSize = true;
            lblStatusCaption.Location = new Point(18, 225);
            lblStatusCaption.Name = "lblStatusCaption";
            lblStatusCaption.Size = new Size(86, 15);
            lblStatusCaption.TabIndex = 12;
            lblStatusCaption.Text = "Booking Status";
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new Point(249, 191);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(81, 15);
            lblAppointmentTime.TabIndex = 13;
            lblAppointmentTime.Text = "Booking Time";
            // 
            // lblTimeCaption
            // 
            lblTimeCaption.AutoSize = true;
            lblTimeCaption.Location = new Point(18, 191);
            lblTimeCaption.Name = "lblTimeCaption";
            lblTimeCaption.Size = new Size(108, 15);
            lblTimeCaption.TabIndex = 14;
            lblTimeCaption.Text = "Appointment Time";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(18, 312);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(344, 53);
            btnDone.TabIndex = 15;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // BookingConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDone);
            Controls.Add(lblTimeCaption);
            Controls.Add(lblAppointmentTime);
            Controls.Add(lblStatusCaption);
            Controls.Add(lblBookingStatus);
            Controls.Add(lblServiceName);
            Controls.Add(lblCentreCaption);
            Controls.Add(lblCentreName);
            Controls.Add(lblDateCaption);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblReferenceNumber);
            Controls.Add(lblInstruction);
            Controls.Add(lblReferenceCaption);
            Controls.Add(lblServiceCaption);
            Controls.Add(btnCreateAnother);
            Controls.Add(lblHeading);
            Name = "BookingConfirmationForm";
            Text = "BookingConfirmationForm";
            Load += BookingConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}