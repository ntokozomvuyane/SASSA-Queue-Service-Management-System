
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
            btnLogout = new Button();
            btnMyProfile = new Button();
            btnQueueStatus = new Button();
            btnMyBooking = new Button();
            btnNewBooking = new Button();
            btnDashboard = new Button();
            lblPersonalInformation = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblBeneficiaryId = new Label();
            txtUserID = new TextBox();
            lblPhoneNumber = new Label();
            txtContactNumber = new TextBox();
            lblEmailAddress = new Label();
            txtUsername = new TextBox();
            lblPreferredCentre = new Label();
            btnSave = new Button();
            btnBack = new Button();
            cboPreferredCentre = new ComboBox();
            panel1.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.Controls.Add(lblBeneficiaryPortal);
            panel1.Controls.Add(lblBeneficiaryDetails);
            panel1.Controls.Add(lblMyProfile);
            panel1.Controls.Add(lblSassa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 75);
            panel1.TabIndex = 0;
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBeneficiaryPortal.ForeColor = Color.White;
            lblBeneficiaryPortal.Location = new Point(886, 27);
            lblBeneficiaryPortal.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(120, 15);
            lblBeneficiaryPortal.TabIndex = 3;
            lblBeneficiaryPortal.Text = "Beneficiary Portal";
            // 
            // lblBeneficiaryDetails
            // 
            lblBeneficiaryDetails.AutoSize = true;
            lblBeneficiaryDetails.ForeColor = Color.White;
            lblBeneficiaryDetails.Location = new Point(148, 38);
            lblBeneficiaryDetails.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryDetails.Name = "lblBeneficiaryDetails";
            lblBeneficiaryDetails.Size = new Size(220, 15);
            lblBeneficiaryDetails.TabIndex = 2;
            lblBeneficiaryDetails.Text = "View and update your beneficiary details";
            // 
            // lblMyProfile
            // 
            lblMyProfile.AutoSize = true;
            lblMyProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyProfile.ForeColor = Color.White;
            lblMyProfile.Location = new Point(144, 10);
            lblMyProfile.Margin = new Padding(4, 0, 4, 0);
            lblMyProfile.Name = "lblMyProfile";
            lblMyProfile.Size = new Size(87, 20);
            lblMyProfile.TabIndex = 1;
            lblMyProfile.Text = "My Profile";
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(35, 15);
            lblSassa.Margin = new Padding(4, 0, 4, 0);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(87, 25);
            lblSassa.TabIndex = 0;
            lblSassa.Text = "SASSA";
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
            pnlSideBar.Location = new Point(0, 70);
            pnlSideBar.Margin = new Padding(4, 3, 4, 3);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(180, 546);
            pnlSideBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(14, 244);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 35);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnSignOut_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(14, 200);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(131, 35);
            btnMyProfile.TabIndex = 10;
            btnMyProfile.Text = "Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // btnQueueStatus
            // 
            btnQueueStatus.Location = new Point(14, 150);
            btnQueueStatus.Name = "btnQueueStatus";
            btnQueueStatus.Size = new Size(131, 35);
            btnQueueStatus.TabIndex = 9;
            btnQueueStatus.Text = "Queue Status";
            btnQueueStatus.UseVisualStyleBackColor = true;
            btnQueueStatus.Click += btnQueueStatus_Click;
            // 
            // btnMyBooking
            // 
            btnMyBooking.Location = new Point(12, 109);
            btnMyBooking.Name = "btnMyBooking";
            btnMyBooking.Size = new Size(131, 35);
            btnMyBooking.TabIndex = 8;
            btnMyBooking.Text = "My Booking";
            btnMyBooking.UseVisualStyleBackColor = true;
            btnMyBooking.Click += btnMyBookings_Click;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Location = new Point(13, 68);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(131, 35);
            btnNewBooking.TabIndex = 7;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = true;
            btnNewBooking.Click += btnNewBooking_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(13, 24);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 35);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblPersonalInformation
            // 
            lblPersonalInformation.AutoSize = true;
            lblPersonalInformation.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonalInformation.Location = new Point(204, 105);
            lblPersonalInformation.Margin = new Padding(4, 0, 4, 0);
            lblPersonalInformation.Name = "lblPersonalInformation";
            lblPersonalInformation.Size = new Size(149, 16);
            lblPersonalInformation.TabIndex = 2;
            lblPersonalInformation.Text = "Personal Information";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = SystemColors.ControlDarkDark;
            lblFullName.Location = new Point(208, 148);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Location = new Point(208, 166);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(523, 23);
            txtFullName.TabIndex = 4;
            txtFullName.Text = "Test Beneficiary";
            // 
            // lblBeneficiaryId
            // 
            lblBeneficiaryId.AutoSize = true;
            lblBeneficiaryId.ForeColor = SystemColors.ControlDarkDark;
            lblBeneficiaryId.Location = new Point(208, 198);
            lblBeneficiaryId.Margin = new Padding(4, 0, 4, 0);
            lblBeneficiaryId.Name = "lblBeneficiaryId";
            lblBeneficiaryId.Size = new Size(79, 15);
            lblBeneficiaryId.TabIndex = 5;
            lblBeneficiaryId.Text = "Beneficiary ID";
            // 
            // txtUserID
            // 
            txtUserID.BackColor = Color.White;
            txtUserID.Location = new Point(211, 218);
            txtUserID.Margin = new Padding(4, 3, 4, 3);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(520, 23);
            txtUserID.TabIndex = 6;
            txtUserID.Text = "SASSA-123456789";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = SystemColors.ButtonFace;
            lblPhoneNumber.ForeColor = SystemColors.ControlDarkDark;
            lblPhoneNumber.Location = new Point(208, 257);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtContactNumber
            // 
            txtContactNumber.BackColor = Color.White;
            txtContactNumber.Location = new Point(208, 277);
            txtContactNumber.Margin = new Padding(4, 3, 4, 3);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(523, 23);
            txtContactNumber.TabIndex = 8;
            txtContactNumber.Text = "071 234 5678";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.ForeColor = SystemColors.ControlDarkDark;
            lblEmailAddress.Location = new Point(208, 314);
            lblEmailAddress.Margin = new Padding(4, 0, 4, 0);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(81, 15);
            lblEmailAddress.TabIndex = 9;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(211, 333);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(520, 23);
            txtUsername.TabIndex = 10;
            txtUsername.Text = "beneficiary@example.com";
            // 
            // lblPreferredCentre
            // 
            lblPreferredCentre.AutoSize = true;
            lblPreferredCentre.ForeColor = SystemColors.ControlDarkDark;
            lblPreferredCentre.Location = new Point(211, 365);
            lblPreferredCentre.Margin = new Padding(4, 0, 4, 0);
            lblPreferredCentre.Name = "lblPreferredCentre";
            lblPreferredCentre.Size = new Size(93, 15);
            lblPreferredCentre.TabIndex = 11;
            lblPreferredCentre.Text = "Preferred Centre";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 51, 102);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(786, 452);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 42);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 51, 102);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(786, 516);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 43);
            btnBack.TabIndex = 14;
            btnBack.Text = "Sign Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cboPreferredCentre
            // 
            cboPreferredCentre.FormattingEnabled = true;
            cboPreferredCentre.Location = new Point(214, 389);
            cboPreferredCentre.Name = "cboPreferredCentre";
            cboPreferredCentre.Size = new Size(448, 23);
            cboPreferredCentre.TabIndex = 15;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 614);
            Controls.Add(cboPreferredCentre);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(lblPreferredCentre);
            Controls.Add(txtUsername);
            Controls.Add(lblEmailAddress);
            Controls.Add(txtContactNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtUserID);
            Controls.Add(lblBeneficiaryId);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblPersonalInformation);
            Controls.Add(pnlSideBar);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfileForm";
            WindowState = FormWindowState.Maximized;
            Load += BeneficiaryProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSideBar.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPersonalInformation;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBeneficiaryId;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPreferredCentre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private Button btnNewBooking;
        private Button btnDashboard;
        private Button btnMyProfile;
        private Button btnQueueStatus;
        private Button btnMyBooking;
        private Button btnLogout;
        private ComboBox cboPreferredCentre;
    }
}