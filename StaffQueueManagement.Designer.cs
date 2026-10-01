namespace SASSAQueueManagementSystem
{
    partial class StaffQueueForm
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
            pnlStaff = new Panel();
            btnSignOut = new Button();
            label2 = new Label();
            SASSA = new Label();
            pnlSearchBooking = new Panel();
            lblSearchBooking = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchResult = new Label();
            pnlStaff.SuspendLayout();
            pnlSearchBooking.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStaff
            // 
            pnlStaff.BackColor = Color.FromArgb(0, 51, 102);
            pnlStaff.BorderStyle = BorderStyle.Fixed3D;
            pnlStaff.Controls.Add(btnSignOut);
            pnlStaff.Controls.Add(label2);
            pnlStaff.Controls.Add(SASSA);
            pnlStaff.Dock = DockStyle.Top;
            pnlStaff.ForeColor = Color.Black;
            pnlStaff.Location = new Point(0, 0);
            pnlStaff.Margin = new Padding(2, 2, 2, 2);
            pnlStaff.Name = "pnlStaff";
            pnlStaff.Size = new Size(852, 50);
            pnlStaff.TabIndex = 0;
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(596, 15);
            btnSignOut.Margin = new Padding(2, 2, 2, 2);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(78, 28);
            btnSignOut.TabIndex = 2;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(15, 28);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Staff Console";
            // 
            // SASSA
            // 
            SASSA.AutoSize = true;
            SASSA.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SASSA.ForeColor = Color.White;
            SASSA.Location = new Point(8, 5);
            SASSA.Margin = new Padding(2, 0, 2, 0);
            SASSA.Name = "SASSA";
            SASSA.Size = new Size(68, 25);
            SASSA.TabIndex = 0;
            SASSA.Text = "SASSA";
            SASSA.Click += SASSA_Click;
            // 
            // pnlSearchBooking
            // 
            pnlSearchBooking.BorderStyle = BorderStyle.Fixed3D;
            pnlSearchBooking.Controls.Add(lblSearchResult);
            pnlSearchBooking.Controls.Add(lblSearchBooking);
            pnlSearchBooking.Controls.Add(pnlSearch);
            pnlSearchBooking.Controls.Add(label1);
            pnlSearchBooking.Location = new Point(11, 64);
            pnlSearchBooking.Margin = new Padding(2, 2, 2, 2);
            pnlSearchBooking.Name = "pnlSearchBooking";
            pnlSearchBooking.Size = new Size(702, 290);
            pnlSearchBooking.TabIndex = 1;
            // 
            // lblSearchBooking
            // 
            lblSearchBooking.AutoSize = true;
            lblSearchBooking.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBooking.Location = new Point(7, 15);
            lblSearchBooking.Margin = new Padding(2, 0, 2, 0);
            lblSearchBooking.Name = "lblSearchBooking";
            lblSearchBooking.Size = new Size(173, 30);
            lblSearchBooking.TabIndex = 1;
            lblSearchBooking.Text = "Search Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.ButtonHighlight;
            pnlSearch.BorderStyle = BorderStyle.Fixed3D;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Location = new Point(15, 52);
            pnlSearch.Margin = new Padding(2, 2, 2, 2);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(659, 88);
            pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(46, 41);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Reference number ,name ,ID or phone...";
            txtSearch.Size = new Size(488, 26);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(8, 5);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblSearchResult
            // 
            lblSearchResult.AutoSize = true;
            lblSearchResult.Location = new Point(311, 161);
            lblSearchResult.Margin = new Padding(2, 0, 2, 0);
            lblSearchResult.Name = "lblSearchResult";
            lblSearchResult.Size = new Size(77, 15);
            lblSearchResult.TabIndex = 3;
            lblSearchResult.Text = "Search Result";
            // 
            // StaffQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(852, 441);
            Controls.Add(pnlSearchBooking);
            Controls.Add(pnlStaff);
            Margin = new Padding(2, 2, 2, 2);
            Name = "StaffQueueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Queue Management";
            pnlStaff.ResumeLayout(false);
            pnlStaff.PerformLayout();
            pnlSearchBooking.ResumeLayout(false);
            pnlSearchBooking.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel pnlStaff;
        private Label SASSA;
        private Panel pnlSearchBooking;
        private Label label1;
        private Button btnSignOut;
        private Label label2;
        private Label lblSearchBooking;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblSearchResult;
    }
}