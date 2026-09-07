namespace Sassa_Queue_And_Service_Management_System
{
    partial class frmBeneficiary_welcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeneficiary_welcomePage));
            this.pctSassaLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctSassaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSassaLogo
            // 
            this.pctSassaLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctSassaLogo.Image")));
            this.pctSassaLogo.Location = new System.Drawing.Point(-2, 0);
            this.pctSassaLogo.Name = "pctSassaLogo";
            this.pctSassaLogo.Size = new System.Drawing.Size(545, 774);
            this.pctSassaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSassaLogo.TabIndex = 0;
            this.pctSassaLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.lblWelcome.Location = new System.Drawing.Point(630, 53);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(194, 38);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(117)))), ((int)(((byte)(115)))));
            this.lblSlogan.Location = new System.Drawing.Point(608, 108);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(345, 18);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Access your SASSA Queue Booking account";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(598, 439);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(355, 61);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create New Account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(598, 338);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(355, 61);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login to My Account";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnCheckStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(122)))));
            this.btnCheckStatus.Location = new System.Drawing.Point(599, 548);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(355, 61);
            this.btnCheckStatus.TabIndex = 6;
            this.btnCheckStatus.Text = "Check Queue Status (No Login)";
            this.btnCheckStatus.UseVisualStyleBackColor = false;
            // 
            // frmBeneficiary_welcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 775);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pctSassaLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBeneficiary_welcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiary_welcomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctSassaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSassaLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCheckStatus;
    }
}