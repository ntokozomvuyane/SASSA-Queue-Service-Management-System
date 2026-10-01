
namespace Sassa_Queue_And_Service_Management_System
{
    partial class MyProfileForm
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
            lblBeneficiaryDetails = new Label();
            lblMyProfile = new Label();
            lblSassa = new Label();
            pnlSideBar = new Panel();
            lblSignOut = new Label();
            lblProfile = new Label();
            lblQueueStatus = new Label();
            lblMyBookings = new Label();
            lblNewBooking = new Label();
            lblDashboard = new Label();
            lblPersonalInformation = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblBeneficiaryId = new Label();
            txtBeneficiaryId = new TextBox();
            lblPhoneNumber = new Label();
            textBox1 = new TextBox();
            lblEmailAddress = new Label();
            txtEmailAddress = new TextBox();
            lblPreferredCentre = new Label();
            txtPreferredCentre = new TextBox();
            btnSaveChanges = new Button();
            btnSignOut = new Button();
            panel1.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 74, 122);
            panel1.Controls.Add(lblBeneficiaryPortal);
            panel1.Controls.Add(lblBeneficiaryDetails);
            panel1.Controls.Add(lblMyProfile);
            panel1.Controls.Add(lblSassa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 95);
            panel1.TabIndex = 0;
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeneficiaryPortal.ForeColor = Color.White;
            lblBeneficiaryPortal.Location = new Point(1138, 35);
            lblBeneficiaryPortal.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(141, 18);
            lblBeneficiaryPortal.TabIndex = 3;
            lblBeneficiaryPortal.Text = "Beneficiary Portal";
            // 
            // lblBeneficiaryDetails
            // 
            lblBeneficiaryDetails.AutoSize = true;
            lblBeneficiaryDetails.ForeColor = Color.White;
            lblBeneficiaryDetails.Location = new Point(190, 51);
            lblBeneficiaryDetails.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryDetails.Name = "lblBeneficiaryDetails";
            lblBeneficiaryDetails.Size = new Size(294, 20);
            lblBeneficiaryDetails.TabIndex = 2;
            lblBeneficiaryDetails.Text = "View and update your beneficiary details";
            // 
            // lblMyProfile
            // 
            lblMyProfile.AutoSize = true;
            lblMyProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyProfile.ForeColor = Color.White;
            lblMyProfile.Location = new Point(184, 14);
            lblMyProfile.Margin = new Padding(4, 0, 4, 0);
            lblMyProfile.Name = "lblMyProfile";
            lblMyProfile.Size = new Size(108, 25);
            lblMyProfile.TabIndex = 1;
            lblMyProfile.Text = "My Profile";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(45, 20);
            lblSassa.Margin = new Padding(4, 0, 4, 0);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(109, 31);
            lblSassa.TabIndex = 0;
            lblSassa.Text = "SASSA";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.WhiteSmoke;
            pnlSideBar.Controls.Add(lblSignOut);
            pnlSideBar.Controls.Add(lblProfile);
            pnlSideBar.Controls.Add(lblQueueStatus);
            pnlSideBar.Controls.Add(lblMyBookings);
            pnlSideBar.Controls.Add(lblNewBooking);
            pnlSideBar.Controls.Add(lblDashboard);
            pnlSideBar.Location = new Point(0, 94);
            pnlSideBar.Margin = new Padding(4, 5, 4, 5);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(231, 723);
            pnlSideBar.TabIndex = 1;
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Location = new Point(18, 418);
            lblSignOut.Margin = new Padding(4, 0, 4, 0);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(69, 20);
            lblSignOut.TabIndex = 5;
            lblSignOut.Text = "Sign Out";
            // 
            // lblProfile
            // 
            lblProfile.BackColor = Color.FromArgb(173, 216, 255);
            lblProfile.Location = new Point(18, 325);
            lblProfile.Margin = new Padding(4, 0, 4, 0);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(208, 42);
            lblProfile.TabIndex = 4;
            lblProfile.Text = "Profile";
            lblProfile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQueueStatus
            // 
            lblQueueStatus.AutoSize = true;
            lblQueueStatus.Location = new Point(18, 249);
            lblQueueStatus.Margin = new Padding(4, 0, 4, 0);
            lblQueueStatus.Name = "lblQueueStatus";
            lblQueueStatus.Size = new Size(102, 20);
            lblQueueStatus.TabIndex = 3;
            lblQueueStatus.Text = "Queue Status";
            // 
            // lblMyBookings
            // 
            lblMyBookings.AutoSize = true;
            lblMyBookings.Location = new Point(18, 171);
            lblMyBookings.Margin = new Padding(4, 0, 4, 0);
            lblMyBookings.Name = "lblMyBookings";
            lblMyBookings.Size = new Size(100, 20);
            lblMyBookings.TabIndex = 2;
            lblMyBookings.Text = "My Bookings";
            // 
            // lblNewBooking
            // 
            lblNewBooking.AutoSize = true;
            lblNewBooking.Location = new Point(18, 103);
            lblNewBooking.Margin = new Padding(4, 0, 4, 0);
            lblNewBooking.Name = "lblNewBooking";
            lblNewBooking.Size = new Size(103, 20);
            lblNewBooking.TabIndex = 1;
            lblNewBooking.Text = "New Booking";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(18, 32);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(85, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // lblPersonalInformation
            // 
            lblPersonalInformation.AutoSize = true;
            lblPersonalInformation.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonalInformation.Location = new Point(262, 140);
            lblPersonalInformation.Margin = new Padding(4, 0, 4, 0);
            lblPersonalInformation.Name = "lblPersonalInformation";
            lblPersonalInformation.Size = new Size(183, 20);
            lblPersonalInformation.TabIndex = 2;
            lblPersonalInformation.Text = "Personal Information";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = SystemColors.ControlDarkDark;
            lblFullName.Location = new Point(267, 197);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Location = new Point(267, 222);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(671, 27);
            txtFullName.TabIndex = 4;
            txtFullName.Text = "Test Beneficiary";
            // 
            // lblBeneficiaryId
            // 
            lblBeneficiaryId.AutoSize = true;
            lblBeneficiaryId.ForeColor = SystemColors.ControlDarkDark;
            lblBeneficiaryId.Location = new Point(267, 265);
            lblBeneficiaryId.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryId.Name = "lblBeneficiaryId";
            lblBeneficiaryId.Size = new Size(108, 20);
            lblBeneficiaryId.TabIndex = 5;
            lblBeneficiaryId.Text = "Beneficiary ID";
            // 
            // txtBeneficiaryId
            // 
            txtBeneficiaryId.BackColor = Color.White;
            txtBeneficiaryId.Location = new Point(271, 291);
            txtBeneficiaryId.Margin = new Padding(4, 5, 4, 5);
            txtBeneficiaryId.Name = "txtBeneficiaryId";
            txtBeneficiaryId.Size = new Size(667, 27);
            txtBeneficiaryId.TabIndex = 6;
            txtBeneficiaryId.Text = "SASSA-123456789";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = SystemColors.ButtonFace;
            lblPhoneNumber.ForeColor = SystemColors.ControlDarkDark;
            lblPhoneNumber.Location = new Point(267, 343);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(115, 20);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(267, 369);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(671, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "071 234 5678";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.ForeColor = SystemColors.ControlDarkDark;
            lblEmailAddress.Location = new Point(267, 418);
            lblEmailAddress.Margin = new Padding(4, 0, 4, 0);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(108, 20);
            lblEmailAddress.TabIndex = 9;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(271, 445);
            txtEmailAddress.Margin = new Padding(4, 5, 4, 5);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(667, 27);
            txtEmailAddress.TabIndex = 10;
            txtEmailAddress.Text = "beneficiary@example.com";
            // 
            // lblPreferredCentre
            // 
            lblPreferredCentre.AutoSize = true;
            lblPreferredCentre.ForeColor = SystemColors.ControlDarkDark;
            lblPreferredCentre.Location = new Point(271, 486);
            lblPreferredCentre.Margin = new Padding(4, 0, 4, 0);
            lblPreferredCentre.Name = "lblPreferredCentre";
            lblPreferredCentre.Size = new Size(125, 20);
            lblPreferredCentre.TabIndex = 11;
            lblPreferredCentre.Text = "Preferred Centre";
            // 
            // txtPreferredCentre
            // 
            txtPreferredCentre.Location = new Point(276, 512);
            txtPreferredCentre.Margin = new Padding(4, 5, 4, 5);
            txtPreferredCentre.Name = "txtPreferredCentre";
            txtPreferredCentre.Size = new Size(662, 27);
            txtPreferredCentre.TabIndex = 12;
            txtPreferredCentre.Text = "Johannesburg Centre SASSA Centre";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(26, 74, 122);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(1011, 603);
            btnSaveChanges.Margin = new Padding(4, 5, 4, 5);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(189, 55);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(26, 74, 122);
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = Color.White;
            btnSignOut.Location = new Point(1011, 688);
            btnSignOut.Margin = new Padding(4, 5, 4, 5);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(189, 57);
            btnSignOut.TabIndex = 14;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 818);
            Controls.Add(btnSignOut);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtPreferredCentre);
            Controls.Add(lblPreferredCentre);
            Controls.Add(txtEmailAddress);
            Controls.Add(lblEmailAddress);
            Controls.Add(textBox1);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtBeneficiaryId);
            Controls.Add(lblBeneficiaryId);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblPersonalInformation);
            Controls.Add(pnlSideBar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfileForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBeneficiaryPortal;
        private System.Windows.Forms.Label lblBeneficiaryDetails;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblSassa;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblQueueStatus;
        private System.Windows.Forms.Label lblMyBookings;
        private System.Windows.Forms.Label lblNewBooking;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Label lblPersonalInformation;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBeneficiaryId;
        private System.Windows.Forms.TextBox txtBeneficiaryId;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblPreferredCentre;
        private System.Windows.Forms.TextBox txtPreferredCentre;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnSignOut;
    }
}