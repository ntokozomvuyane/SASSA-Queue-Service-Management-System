namespace Sassa_Queue_And_Service_Management_System
{
    partial class Logout_form
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
            this.lblsignout = new System.Windows.Forms.Label();
            this.lblAreyousure = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.menuePanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQueueStatus = new System.Windows.Forms.Button();
            this.btnMyBooking = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SignOutPanel = new System.Windows.Forms.Panel();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblPortal = new System.Windows.Forms.Label();
            this.lblSassa = new System.Windows.Forms.Label();
            this.menuePanel.SuspendLayout();
            this.SignOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsignout
            // 
            this.lblsignout.AutoSize = true;
            this.lblsignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignout.Location = new System.Drawing.Point(544, 173);
            this.lblsignout.Name = "lblsignout";
            this.lblsignout.Size = new System.Drawing.Size(94, 22);
            this.lblsignout.TabIndex = 30;
            this.lblsignout.Text = "Sign Out ";
            // 
            // lblAreyousure
            // 
            this.lblAreyousure.AutoSize = true;
            this.lblAreyousure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreyousure.Location = new System.Drawing.Point(431, 223);
            this.lblAreyousure.Name = "lblAreyousure";
            this.lblAreyousure.Size = new System.Drawing.Size(321, 22);
            this.lblAreyousure.TabIndex = 31;
            this.lblAreyousure.Text = "Are you sure you want to sign out?";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(290, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(278, 49);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(633, 287);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(278, 49);
            this.btnSignout.TabIndex = 43;
            this.btnSignout.Text = "Sign Out";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // menuePanel
            // 
            this.menuePanel.BackColor = System.Drawing.Color.White;
            this.menuePanel.Controls.Add(this.btnLogout);
            this.menuePanel.Controls.Add(this.btnProfile);
            this.menuePanel.Controls.Add(this.btnQueueStatus);
            this.menuePanel.Controls.Add(this.btnMyBooking);
            this.menuePanel.Controls.Add(this.btnNewBooking);
            this.menuePanel.Controls.Add(this.btnDashboard);
            this.menuePanel.Location = new System.Drawing.Point(12, 76);
            this.menuePanel.Name = "menuePanel";
            this.menuePanel.Size = new System.Drawing.Size(183, 526);
            this.menuePanel.TabIndex = 44;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(16, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(144, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(16, 269);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(144, 40);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnQueueStatus
            // 
            this.btnQueueStatus.Location = new System.Drawing.Point(16, 210);
            this.btnQueueStatus.Name = "btnQueueStatus";
            this.btnQueueStatus.Size = new System.Drawing.Size(144, 40);
            this.btnQueueStatus.TabIndex = 3;
            this.btnQueueStatus.Text = "Queue Status";
            this.btnQueueStatus.UseVisualStyleBackColor = true;
            // 
            // btnMyBooking
            // 
            this.btnMyBooking.Location = new System.Drawing.Point(16, 155);
            this.btnMyBooking.Name = "btnMyBooking";
            this.btnMyBooking.Size = new System.Drawing.Size(144, 40);
            this.btnMyBooking.TabIndex = 2;
            this.btnMyBooking.Text = "My Booking";
            this.btnMyBooking.UseVisualStyleBackColor = true;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Location = new System.Drawing.Point(16, 103);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(144, 40);
            this.btnNewBooking.TabIndex = 1;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(16, 47);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(144, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // SignOutPanel
            // 
            this.SignOutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.SignOutPanel.Controls.Add(this.lbllogout);
            this.SignOutPanel.Controls.Add(this.lblPortal);
            this.SignOutPanel.Controls.Add(this.lblSassa);
            this.SignOutPanel.Location = new System.Drawing.Point(12, 12);
            this.SignOutPanel.Name = "SignOutPanel";
            this.SignOutPanel.Size = new System.Drawing.Size(958, 58);
            this.SignOutPanel.TabIndex = 45;
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllogout.Location = new System.Drawing.Point(113, 17);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(88, 22);
            this.lbllogout.TabIndex = 20;
            this.lbllogout.Text = "Sign Out";
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPortal.Location = new System.Drawing.Point(781, 28);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(142, 20);
            this.lblPortal.TabIndex = 19;
            this.lblPortal.Text = "Beneficiary Portal";
            // 
            // lblSassa
            // 
            this.lblSassa.AutoSize = true;
            this.lblSassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSassa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSassa.Location = new System.Drawing.Point(11, 19);
            this.lblSassa.Name = "lblSassa";
            this.lblSassa.Size = new System.Drawing.Size(96, 29);
            this.lblSassa.TabIndex = 17;
            this.lblSassa.Text = "SASSA";
            // 
            // Logout_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 632);
            this.Controls.Add(this.SignOutPanel);
            this.Controls.Add(this.menuePanel);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAreyousure);
            this.Controls.Add(this.lblsignout);
            this.Name = "Logout_form";
            this.Text = "Logout_form";
            this.menuePanel.ResumeLayout(false);
            this.SignOutPanel.ResumeLayout(false);
            this.SignOutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsignout;
        private System.Windows.Forms.Label lblAreyousure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Panel menuePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnQueueStatus;
        private System.Windows.Forms.Button btnMyBooking;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel SignOutPanel;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.Label lblSassa;
    }
}