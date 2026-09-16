namespace SASSAQueueManagementSystem
{
    partial class frmRegistrationForm
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
            pnlHeading = new Panel();
            lblSassa = new Label();
            lblBeneficiaryRegistration = new Label();
            lblSlogan = new Label();
            lblBeneficiaryPortal = new Label();
            panel1 = new Panel();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtID = new TextBox();
            lblBeneficiaryId = new Label();
            lblCreateAccount = new Label();
            btnCreateAccount = new Button();
            btnBack = new Button();
            pnlHeading.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.FromArgb(26, 74, 122);
            pnlHeading.Controls.Add(lblSassa);
            pnlHeading.Controls.Add(lblBeneficiaryRegistration);
            pnlHeading.Controls.Add(lblSlogan);
            pnlHeading.Controls.Add(lblBeneficiaryPortal);
            pnlHeading.Location = new Point(1, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(1079, 78);
            pnlHeading.TabIndex = 4;
            // 
            // lblSassa
            // 
            lblSassa.AutoSize = true;
            lblSassa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSassa.ForeColor = Color.White;
            lblSassa.Location = new Point(3, 16);
            lblSassa.Name = "lblSassa";
            lblSassa.Size = new Size(105, 38);
            lblSassa.TabIndex = 5;
            lblSassa.Text = "SASSA";
            // 
            // lblBeneficiaryRegistration
            // 
            lblBeneficiaryRegistration.AutoSize = true;
            lblBeneficiaryRegistration.ForeColor = Color.White;
            lblBeneficiaryRegistration.Location = new Point(114, 16);
            lblBeneficiaryRegistration.Name = "lblBeneficiaryRegistration";
            lblBeneficiaryRegistration.Size = new Size(177, 20);
            lblBeneficiaryRegistration.TabIndex = 4;
            lblBeneficiaryRegistration.Text = "Beneficiaty Registration";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(114, 43);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(312, 40);
            lblSlogan.TabIndex = 3;
            lblSlogan.Text = "Secure your access to your SASSA bookings\r\n\r\n";
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.ForeColor = Color.White;
            lblBeneficiaryPortal.Location = new Point(921, 34);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(133, 20);
            lblBeneficiaryPortal.TabIndex = 2;
            lblBeneficiaryPortal.Text = "Beneficiaty Portal";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lblBeneficiaryId);
            panel1.Controls.Add(lblCreateAccount);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Location = new Point(115, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 658);
            panel1.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(88, 537);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(440, 27);
            txtConfirmPassword.TabIndex = 18;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(88, 491);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(133, 20);
            lblConfirmPassword.TabIndex = 17;
            lblConfirmPassword.Text = "ConfirmPassword";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 346);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 27);
            txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 301);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtFullName.Location = new Point(88, 142);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(440, 23);
            txtFullName.TabIndex = 14;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(88, 86);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(84, 18);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "Full Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 439);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(440, 27);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(88, 402);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // txtID
            // 
            txtID.Location = new Point(88, 244);
            txtID.Name = "txtID";
            txtID.Size = new Size(440, 27);
            txtID.TabIndex = 10;
            // 
            // lblBeneficiaryId
            // 
            lblBeneficiaryId.AutoSize = true;
            lblBeneficiaryId.Location = new Point(76, 193);
            lblBeneficiaryId.Name = "lblBeneficiaryId";
            lblBeneficiaryId.Size = new Size(108, 20);
            lblBeneficiaryId.TabIndex = 9;
            lblBeneficiaryId.Text = "Beneficiary ID";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateAccount.ForeColor = Color.Black;
            lblCreateAccount.Location = new Point(85, 9);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(323, 50);
            lblCreateAccount.TabIndex = 8;
            lblCreateAccount.Text = "Create an Account";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(26, 74, 122);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(160, 579);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(396, 64);
            btnCreateAccount.TabIndex = 7;
            btnCreateAccount.Text = "Create an Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 74, 122);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(82, 750);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(249, 64);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 826);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(pnlHeading);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmRegistrationForm";
            Text = "RegistrationForm";
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeading;
        private Label lblSassa;
        private Label lblBeneficiaryRegistration;
        private Label lblSlogan;
        private Label lblBeneficiaryPortal;
        private Panel panel1;
        private Button btnCreateAccount;
        private Button btnBack;
        private Label lblCreateAccount;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtID;
        private Label lblBeneficiaryId;
    }
}