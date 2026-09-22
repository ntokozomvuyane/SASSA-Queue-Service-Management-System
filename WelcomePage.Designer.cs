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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnBeneficiaryLogin.Click += btnBeneficiaryLogin_Click;
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
            btnAdmin.Click += btnAdminLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(714, 35);
            label1.Name = "label1";
            label1.Size = new Size(257, 32);
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
            label2.Size = new Size(296, 56);
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
            label3.Size = new Size(279, 38);
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
            label4.Size = new Size(263, 76);
            label4.TabIndex = 7;
            label4.Text = "Together we can build a better future!\r\n\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.staff_icon;
            pictureBox1.Location = new Point(714, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.Admin_icon;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(714, 501);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.Beneficiary_icon;
            pictureBox3.Location = new Point(714, 377);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 736);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}