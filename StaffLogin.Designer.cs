namespace SASSAQueueManagementSystem
{
    partial class StaffLogin
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
            lblStaffLogin = new Label();
            pnlHeader = new Panel();
            lblPortal = new Label();
            panel1 = new Panel();
            lblDashboard = new Label();
            lblQueueOverview = new Label();
            lblProfile = new Label();
            lblSignOut = new Label();
            pnlMain = new Panel();
            pnlLoginCard = new Panel();
            lblTitle = new Label();
            lblStaffID = new Label();
            lblPassword = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            txtStaffID = new TextBox();
            txtPassword = new TextBox();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlLoginCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblStaffLogin
            // 
            lblStaffLogin.AutoSize = true;
            lblStaffLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffLogin.ForeColor = Color.White;
            lblStaffLogin.Location = new Point(0, 14);
            lblStaffLogin.Name = "lblStaffLogin";
            lblStaffLogin.Size = new Size(213, 31);
            lblStaffLogin.TabIndex = 0;
            lblStaffLogin.Text = "SASSA Staff Portal";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 91, 187);
            pnlHeader.Controls.Add(lblPortal);
            pnlHeader.Controls.Add(lblStaffLogin);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.MaximumSize = new Size(0, 90);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1182, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblPortal
            // 
            lblPortal.AutoSize = true;
            lblPortal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortal.ForeColor = Color.White;
            lblPortal.Location = new Point(1061, 19);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(109, 25);
            lblPortal.TabIndex = 2;
            lblPortal.Text = "Staff Portal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 242, 248);
            panel1.Controls.Add(lblSignOut);
            panel1.Controls.Add(lblProfile);
            panel1.Controls.Add(lblQueueOverview);
            panel1.Controls.Add(lblDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 583);
            panel1.TabIndex = 2;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new Point(35, 34);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(82, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Dashboard";
            // 
            // lblQueueOverview
            // 
            lblQueueOverview.AutoSize = true;
            lblQueueOverview.Location = new Point(35, 96);
            lblQueueOverview.Name = "lblQueueOverview";
            lblQueueOverview.Size = new Size(117, 20);
            lblQueueOverview.TabIndex = 1;
            lblQueueOverview.Text = "Queue Overview";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(35, 154);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 20);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "Profile";
            // 
            // lblSignOut
            // 
            lblSignOut.AutoSize = true;
            lblSignOut.Location = new Point(35, 214);
            lblSignOut.Name = "lblSignOut";
            lblSignOut.Size = new Size(66, 20);
            lblSignOut.TabIndex = 3;
            lblSignOut.Text = "Sign Out";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlLoginCard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(982, 583);
            pnlMain.TabIndex = 3;
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(txtStaffID);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(btnClear);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(lblStaffID);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Location = new Point(221, 57);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(500, 430);
            pnlLoginCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(154, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(38, 97);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(63, 20);
            lblStaffID.TabIndex = 1;
            lblStaffID.Text = "Staff ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(38, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(60, 349);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(350, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 91, 187);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(350, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(39, 125);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(340, 27);
            txtStaffID.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 6;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1182, 653);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StaffLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffLogin";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlLoginCard.ResumeLayout(false);
            pnlLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStaffLogin;
        private Panel pnlHeader;
        private Label lblPortal;
        private Panel panel1;
        private Label lblSignOut;
        private Label lblProfile;
        private Label lblQueueOverview;
        private Label lblDashboard;
        private Panel pnlMain;
        private Panel pnlLoginCard;
        private Button btnLogin;
        private Button btnClear;
        private Label lblPassword;
        private Label lblStaffID;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtStaffID;
    }
}