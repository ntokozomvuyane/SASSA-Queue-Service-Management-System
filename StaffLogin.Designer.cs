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
            btnProfile = new Button();
            btnLogout = new Button();
            btnQueueOverview = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            pnlLoginCard = new Panel();
            txtPassword = new TextBox();
            txtStaffID = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            lblPassword = new Label();
            lblStaffID = new Label();
            lblTitle = new Label();
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
            lblStaffLogin.Location = new Point(0, 10);
            lblStaffLogin.Name = "lblStaffLogin";
            lblStaffLogin.Size = new Size(177, 25);
            lblStaffLogin.TabIndex = 0;
            lblStaffLogin.Text = "SASSA Staff Portal";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 51, 102);
            pnlHeader.BorderStyle = BorderStyle.Fixed3D;
            pnlHeader.Controls.Add(lblPortal);
            pnlHeader.Controls.Add(lblStaffLogin);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.MaximumSize = new Size(0, 68);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1034, 52);
            pnlHeader.TabIndex = 1;
            // 
            // lblPortal
            // 
            lblPortal.AutoSize = true;
            lblPortal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortal.ForeColor = Color.White;
            lblPortal.Location = new Point(928, 14);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(89, 20);
            lblPortal.TabIndex = 2;
            lblPortal.Text = "Staff Portal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(234, 242, 248);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnQueueOverview);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 438);
            panel1.TabIndex = 2;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(0, 51, 102);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(30, 116);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(115, 30);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 51, 102);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(30, 157);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(115, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnQueueOverview
            // 
            btnQueueOverview.BackColor = Color.FromArgb(0, 51, 102);
            btnQueueOverview.FlatAppearance.BorderSize = 0;
            btnQueueOverview.FlatStyle = FlatStyle.Flat;
            btnQueueOverview.ForeColor = Color.White;
            btnQueueOverview.Location = new Point(30, 69);
            btnQueueOverview.Margin = new Padding(3, 2, 3, 2);
            btnQueueOverview.Name = "btnQueueOverview";
            btnQueueOverview.Size = new Size(115, 30);
            btnQueueOverview.TabIndex = 6;
            btnQueueOverview.Text = "Queue Overview";
            btnQueueOverview.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 51, 102);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(30, 25);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(116, 30);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.Fixed3D;
            pnlMain.Controls.Add(pnlLoginCard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(175, 52);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(859, 438);
            pnlMain.TabIndex = 3;
            // 
            // pnlLoginCard
            // 
            pnlLoginCard.BorderStyle = BorderStyle.Fixed3D;
            pnlLoginCard.Controls.Add(txtPassword);
            pnlLoginCard.Controls.Add(txtStaffID);
            pnlLoginCard.Controls.Add(btnLogin);
            pnlLoginCard.Controls.Add(btnClear);
            pnlLoginCard.Controls.Add(lblPassword);
            pnlLoginCard.Controls.Add(lblStaffID);
            pnlLoginCard.Controls.Add(lblTitle);
            pnlLoginCard.Location = new Point(193, 43);
            pnlLoginCard.Margin = new Padding(3, 2, 3, 2);
            pnlLoginCard.Name = "pnlLoginCard";
            pnlLoginCard.Size = new Size(438, 322);
            pnlLoginCard.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 155);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(298, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(34, 94);
            txtStaffID.Margin = new Padding(3, 2, 3, 2);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(298, 23);
            txtStaffID.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 51, 102);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(52, 214);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(306, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 51, 102);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(52, 257);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(306, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(33, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaffID.Location = new Point(33, 73);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(51, 15);
            lblStaffID.TabIndex = 1;
            lblStaffID.Text = "Staff ID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(135, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Welcome Back";
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1034, 490);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "StaffLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffLogin";
            Load += StaffLogin_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel pnlMain;
        private Panel pnlLoginCard;
        private Button btnLogin;
        private Button btnClear;
        private Label lblPassword;
        private Label lblStaffID;
        private Label lblTitle;
        private TextBox txtPassword;
        private TextBox txtStaffID;
        private Button btnProfile;
        private Button btnLogout;
        private Button btnQueueOverview;
        private Button btnDashboard;
        private Button button4;
        private Button button2;
    }
}