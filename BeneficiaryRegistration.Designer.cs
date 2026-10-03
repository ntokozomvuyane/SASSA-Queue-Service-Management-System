namespace SASSAQueueManagementSystem
{
    partial class BeneficiaryRegistration
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
            lblCreateAccount = new Label();
            btnCreateAccount = new Button();
            txtEmail = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtFullName = new TextBox();
            lblBeneficiaryID = new Label();
            txtBeneficiaryID = new TextBox();
            lblFullName = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(376, 103);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(196, 30);
            lblCreateAccount.TabIndex = 3;
            lblCreateAccount.Text = "Create an Account";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(26, 74, 122);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(513, 670);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(272, 53);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "Create an account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(344, 409);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 23);
            txtEmail.TabIndex = 15;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(336, 573);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(107, 15);
            lblConfirmPassword.TabIndex = 14;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(344, 614);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(379, 23);
            txtConfirmPassword.TabIndex = 17;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(336, 370);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email\r\n";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 508);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(379, 23);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(336, 464);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(344, 213);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(379, 23);
            txtFullName.TabIndex = 21;
            // 
            // lblBeneficiaryID
            // 
            lblBeneficiaryID.AutoSize = true;
            lblBeneficiaryID.Location = new Point(328, 269);
            lblBeneficiaryID.Name = "lblBeneficiaryID";
            lblBeneficiaryID.Size = new Size(86, 15);
            lblBeneficiaryID.TabIndex = 20;
            lblBeneficiaryID.Text = "Beneficiary ID";
            // 
            // txtBeneficiaryID
            // 
            txtBeneficiaryID.Location = new Point(344, 302);
            txtBeneficiaryID.Name = "txtBeneficiaryID";
            txtBeneficiaryID.Size = new Size(379, 23);
            txtBeneficiaryID.TabIndex = 23;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(336, 181);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(62, 15);
            lblFullName.TabIndex = 22;
            lblFullName.Text = "Full Name";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(247, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 653);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 74, 122);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(51, 86);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(190, 53);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BeneficiaryRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 749);
            Controls.Add(btnBack);
            Controls.Add(txtBeneficiaryID);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblBeneficiaryID);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirmPassword);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblCreateAccount);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "BeneficiaryRegistration";
            Text = "BeneficiaryRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCreateAccount;
        private Button btnCreateAccount;
        private TextBox txtEmail;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtFullName;
        private Label lblBeneficiaryID;
        private TextBox txtBeneficiaryID;
        private Label lblFullName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBack;
    }
}