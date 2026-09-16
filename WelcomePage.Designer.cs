namespace SASSAQueueManagementSystem
{
    partial class WelcomePage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnStaffLogin = new Button();
            btnBeneficiaryLogin = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2026_09_15_at_2_44_52_PM;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(2, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(642, 741);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStaffLogin
            // 
            btnStaffLogin.BackColor = Color.CornflowerBlue;
            btnStaffLogin.ForeColor = SystemColors.ControlLightLight;
            btnStaffLogin.Location = new Point(701, 236);
            btnStaffLogin.Name = "btnStaffLogin";
            btnStaffLogin.Size = new Size(400, 88);
            btnStaffLogin.TabIndex = 1;
            btnStaffLogin.Text = "Staff Login";
            btnStaffLogin.UseVisualStyleBackColor = false;
            btnStaffLogin.Click += btnStaffLogin_Click;
            // 
            // btnBeneficiaryLogin
            // 
            btnBeneficiaryLogin.BackColor = Color.Teal;
            btnBeneficiaryLogin.ForeColor = SystemColors.ControlLightLight;
            btnBeneficiaryLogin.Location = new Point(701, 368);
            btnBeneficiaryLogin.Name = "btnBeneficiaryLogin";
            btnBeneficiaryLogin.Size = new Size(400, 88);
            btnBeneficiaryLogin.TabIndex = 2;
            btnBeneficiaryLogin.Text = "Beneficiary Login";
            btnBeneficiaryLogin.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Purple;
            btnAdmin.ForeColor = SystemColors.ControlLightLight;
            btnAdmin.Location = new Point(701, 489);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(400, 86);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin Login";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(714, 35);
            label1.Name = "label1";
            label1.Size = new Size(324, 41);
            label1.TabIndex = 4;
            label1.Text = "WELCOME TO SASSA!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(765, 147);
            label2.Name = "label2";
            label2.Size = new Size(380, 72);
            label2.TabIndex = 5;
            label2.Text = "Easier access.\r\n        Shorter queues.\r\n                     Better service for a brighter tomorrow.\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(727, 89);
            label3.Name = "label3";
            label3.Size = new Size(333, 46);
            label3.TabIndex = 6;
            label3.Text = "Queue and Service Management System\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(765, 598);
            label4.Name = "label4";
            label4.Size = new Size(318, 92);
            label4.TabIndex = 7;
            label4.Text = "Together we can build a better future!\r\n\r\n\r\n\r\n";
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 736);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdmin);
            Controls.Add(btnBeneficiaryLogin);
            Controls.Add(btnStaffLogin);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "WelcomePage";
            Text = "WelcomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnStaffLogin;
        private Button btnBeneficiaryLogin;
        private Button btnAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}