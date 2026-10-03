namespace SASSAQueueManagementSystem
{
    partial class ForgotPassword
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
            txtNewPassword = new TextBox();
            btnResetPassword = new Button();
            lblNewPassword = new Label();
            chkShowNewPassword = new CheckBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowConfirmedPassword = new CheckBox();
            btnBack = new Button();
            lblFullName = new Label();
            txtFullName = new TextBox();
            chkShowFullName = new CheckBox();
            lblUsername = new Label();
            chkShowUsername = new CheckBox();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(56, 164);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(112, 23);
            txtNewPassword.TabIndex = 0;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(56, 259);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(237, 37);
            btnResetPassword.TabIndex = 1;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(56, 136);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(114, 15);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "Enter New Password";
            // 
            // chkShowNewPassword
            // 
            chkShowNewPassword.AutoSize = true;
            chkShowNewPassword.Location = new Point(185, 166);
            chkShowNewPassword.Name = "chkShowNewPassword";
            chkShowNewPassword.Size = new Size(108, 19);
            chkShowNewPassword.TabIndex = 3;
            chkShowNewPassword.Text = "Show Password";
            chkShowNewPassword.UseVisualStyleBackColor = true;
            chkShowNewPassword.CheckedChanged += chkShowNewPassword_CheckedChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(56, 203);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(56, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(112, 23);
            txtConfirmPassword.TabIndex = 5;
            // 
            // chkShowConfirmedPassword
            // 
            chkShowConfirmedPassword.AutoSize = true;
            chkShowConfirmedPassword.Location = new Point(185, 230);
            chkShowConfirmedPassword.Name = "chkShowConfirmedPassword";
            chkShowConfirmedPassword.Size = new Size(108, 19);
            chkShowConfirmedPassword.TabIndex = 6;
            chkShowConfirmedPassword.Text = "Show Password";
            chkShowConfirmedPassword.UseVisualStyleBackColor = true;
            chkShowConfirmedPassword.CheckedChanged += chkShowConfirmedPassword_CheckedChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(56, 302);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(237, 37);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(56, 71);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(114, 15);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Enter your full name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(58, 89);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(112, 23);
            txtFullName.TabIndex = 9;
            // 
            // chkShowFullName
            // 
            chkShowFullName.AutoSize = true;
            chkShowFullName.Location = new Point(185, 93);
            chkShowFullName.Name = "chkShowFullName";
            chkShowFullName.Size = new Size(112, 19);
            chkShowFullName.TabIndex = 10;
            chkShowFullName.Text = "Show Full Name";
            chkShowFullName.UseVisualStyleBackColor = true;
            chkShowFullName.CheckedChanged += chkShowFullName_CheckedChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(56, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Enter your username";
            // 
            // chkShowUsername
            // 
            chkShowUsername.AutoSize = true;
            chkShowUsername.Location = new Point(185, 25);
            chkShowUsername.Name = "chkShowUsername";
            chkShowUsername.Size = new Size(111, 19);
            chkShowUsername.TabIndex = 12;
            chkShowUsername.Text = "Show Username";
            chkShowUsername.UseVisualStyleBackColor = true;
            chkShowUsername.CheckedChanged += chkShowUsername_CheckedChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(58, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(112, 23);
            txtUsername.TabIndex = 13;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(chkShowUsername);
            Controls.Add(lblUsername);
            Controls.Add(chkShowFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(btnBack);
            Controls.Add(chkShowConfirmedPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(chkShowNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(btnResetPassword);
            Controls.Add(txtNewPassword);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewPassword;
        private Button btnResetPassword;
        private Label lblNewPassword;
        private CheckBox chkShowNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowConfirmedPassword;
        private Button btnBack;
        private Label lblFullName;
        private TextBox txtFullName;
        private CheckBox chkShowFullName;
        private Label lblUsername;
        private CheckBox chkShowUsername;
        private TextBox txtUsername;
    }
}