
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
            SuspendLayout();
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
            cboPreferredCentre.Size = new Size(517, 23);
            cboPreferredCentre.TabIndex = 15;
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
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
            Margin = new Padding(4, 3, 4, 3);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfileForm";
            WindowState = FormWindowState.Maximized;
            Load += BeneficiaryProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
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
        private ComboBox cboPreferredCentre;
    }
}