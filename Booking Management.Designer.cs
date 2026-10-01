
namespace Zanele_Admin
{
    partial class Form1
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
            btnReports = new Button();
            btnBookins = new Button();
            btnSlots = new Button();
            btnServices = new Button();
            btnDashboard = new Button();
            grpSearch = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbCentre = new ComboBox();
            cmbStatus = new ComboBox();
            txtSearch = new TextBox();
            dgvBookingManagement = new DataGridView();
            grpAdmin = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            pnlSideBar = new Panel();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingManagement).BeginInit();
            grpAdmin.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.White;
            btnReports.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.ActiveCaptionText;
            btnReports.Location = new Point(30, 162);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(111, 27);
            btnReports.TabIndex = 0;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnBookins
            // 
            btnBookins.BackColor = Color.White;
            btnBookins.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookins.ForeColor = SystemColors.ActiveCaptionText;
            btnBookins.Location = new Point(30, 54);
            btnBookins.Margin = new Padding(4, 3, 4, 3);
            btnBookins.Name = "btnBookins";
            btnBookins.Size = new Size(111, 27);
            btnBookins.TabIndex = 0;
            btnBookins.Text = "Bookings";
            btnBookins.UseVisualStyleBackColor = false;
            // 
            // btnSlots
            // 
            btnSlots.BackColor = Color.White;
            btnSlots.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSlots.ForeColor = SystemColors.ActiveCaptionText;
            btnSlots.Location = new Point(31, 129);
            btnSlots.Margin = new Padding(4, 3, 4, 3);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(111, 27);
            btnSlots.TabIndex = 0;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.White;
            btnServices.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServices.ForeColor = SystemColors.ActiveCaptionText;
            btnServices.Location = new Point(30, 87);
            btnServices.Margin = new Padding(4, 3, 4, 3);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(111, 27);
            btnServices.TabIndex = 0;
            btnServices.Text = "Services";
            btnServices.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashboard.Location = new Point(30, 15);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(111, 27);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // grpSearch
            // 
            grpSearch.BackColor = Color.Transparent;
            grpSearch.Controls.Add(label3);
            grpSearch.Controls.Add(label2);
            grpSearch.Controls.Add(label4);
            grpSearch.Controls.Add(cmbCentre);
            grpSearch.Controls.Add(cmbStatus);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Location = new Point(243, 97);
            grpSearch.Margin = new Padding(4, 3, 4, 3);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(4, 3, 4, 3);
            grpSearch.Size = new Size(677, 113);
            grpSearch.TabIndex = 2;
            grpSearch.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(454, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 2;
            label3.Text = "Centre Filter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(217, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 2;
            label2.Text = "Status Filter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(34, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 2;
            label4.Text = "Search";
            // 
            // cmbCentre
            // 
            cmbCentre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCentre.FormattingEnabled = true;
            cmbCentre.Location = new Point(458, 54);
            cmbCentre.Margin = new Padding(4, 3, 4, 3);
            cmbCentre.Name = "cmbCentre";
            cmbCentre.Size = new Size(179, 27);
            cmbCentre.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(222, 55);
            cmbStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(190, 27);
            cmbStatus.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(28, 55);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 28);
            txtSearch.TabIndex = 0;
            // 
            // dgvBookingManagement
            // 
            dgvBookingManagement.BackgroundColor = SystemColors.ControlLightLight;
            dgvBookingManagement.BorderStyle = BorderStyle.Fixed3D;
            dgvBookingManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingManagement.Location = new Point(243, 228);
            dgvBookingManagement.Margin = new Padding(4, 3, 4, 3);
            dgvBookingManagement.Name = "dgvBookingManagement";
            dgvBookingManagement.Size = new Size(677, 277);
            dgvBookingManagement.TabIndex = 3;
            // 
            // grpAdmin
            // 
            grpAdmin.BackColor = Color.FromArgb(0, 51, 102);
            grpAdmin.Controls.Add(label7);
            grpAdmin.Controls.Add(label6);
            grpAdmin.Controls.Add(label5);
            grpAdmin.Controls.Add(label1);
            grpAdmin.Controls.Add(button1);
            grpAdmin.Location = new Point(1, 3);
            grpAdmin.Margin = new Padding(4, 3, 4, 3);
            grpAdmin.Name = "grpAdmin";
            grpAdmin.Padding = new Padding(4, 3, 4, 3);
            grpAdmin.Size = new Size(939, 87);
            grpAdmin.TabIndex = 4;
            grpAdmin.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(47, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 4;
            label7.Text = "Administration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(46, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 3;
            label6.Text = "Sassa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(696, 45);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 2;
            label5.Text = "Administrator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(660, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Admin Zanele";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(792, 33);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "Sign out";
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(0, 51, 102);
            pnlSideBar.BorderStyle = BorderStyle.Fixed3D;
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Controls.Add(btnReports);
            pnlSideBar.Controls.Add(btnSlots);
            pnlSideBar.Controls.Add(btnServices);
            pnlSideBar.Controls.Add(btnBookins);
            pnlSideBar.Location = new Point(1, 97);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(195, 408);
            pnlSideBar.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(933, 519);
            Controls.Add(pnlSideBar);
            Controls.Add(grpAdmin);
            Controls.Add(dgvBookingManagement);
            Controls.Add(grpSearch);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Booking Management";
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingManagement).EndInit();
            grpAdmin.ResumeLayout(false);
            grpAdmin.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnBookins;
        private System.Windows.Forms.Button btnSlots;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCentre;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBookingManagement;
        private System.Windows.Forms.GroupBox grpAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Panel pnlSideBar;
    }
}

