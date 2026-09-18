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
            panel1 = new Panel();
            lblBeneficiaryPortal = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCreateAccount = new Label();
            btnCreateAccount = new Button();
            btnBack = new Button();
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 74, 122);
            panel1.Controls.Add(lblBeneficiaryPortal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 78);
            panel1.TabIndex = 2;
            // 
            // lblBeneficiaryPortal
            // 
            lblBeneficiaryPortal.AutoSize = true;
            lblBeneficiaryPortal.ForeColor = SystemColors.ControlLightLight;
            lblBeneficiaryPortal.Location = new Point(907, 29);
            lblBeneficiaryPortal.Name = "lblBeneficiaryPortal";
            lblBeneficiaryPortal.Size = new Size(134, 20);
            lblBeneficiaryPortal.TabIndex = 2;
            lblBeneficiaryPortal.Text = "Beneficiary Portal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(99, 20);
            label2.Name = "label2";
            label2.Size = new Size(324, 40);
            label2.TabIndex = 1;
            label2.Text = "Beneficiary Registration                   \r\n           Secure access to your SASSA bookings.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 31);
            label1.TabIndex = 0;
            label1.Text = "SASSA";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(376, 103);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(250, 38);
            lblCreateAccount.TabIndex = 3;
            lblCreateAccount.Text = "Create an Account";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(26, 74, 122);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(289, 670);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(496, 53);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "Create an account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 74, 122);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(25, 746);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(191, 53);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(344, 409);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 27);
            txtEmail.TabIndex = 15;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(336, 573);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 14;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(344, 614);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(379, 27);
            txtConfirmPassword.TabIndex = 17;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(336, 370);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email\r\n";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 508);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(379, 27);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(336, 464);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(344, 213);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(379, 27);
            txtFullName.TabIndex = 21;
            txtFullName.TextChanged += textBox3_TextChanged;
            // 
            // lblBeneficiaryID
            // 
            lblBeneficiaryID.AutoSize = true;
            lblBeneficiaryID.Location = new Point(328, 269);
            lblBeneficiaryID.Name = "lblBeneficiaryID";
            lblBeneficiaryID.Size = new Size(108, 20);
            lblBeneficiaryID.TabIndex = 20;
            lblBeneficiaryID.Text = "Beneficiary ID";
            // 
            // txtBeneficiaryID
            // 
            txtBeneficiaryID.Location = new Point(344, 302);
            txtBeneficiaryID.Name = "txtBeneficiaryID";
            txtBeneficiaryID.Size = new Size(379, 27);
            txtBeneficiaryID.TabIndex = 23;
            txtBeneficiaryID.TextChanged += this.textBox4_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(336, 181);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 22;
            lblFullName.Text = "Full Name";
            lblFullName.Click += this.label6_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Location = new Point(247, 86);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(587, 653);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // BeneficiaryRegistration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 829);
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
            Controls.Add(btnBack);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblCreateAccount);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "BeneficiaryRegistration";
            Text = "BeneficiaryRegistration";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblBeneficiaryPortal;
        private Label label2;
        private Label label1;
        private Label lblCreateAccount;
        private Button btnCreateAccount;
        private Button btnBack;
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
    }
}