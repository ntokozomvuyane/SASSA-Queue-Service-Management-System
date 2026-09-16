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
            panel1 = new Panel();
            panel2 = new Panel();
            SASSA = new Label();
            label1 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSignOut = new Button();
            label3 = new Label();
            pnlSearch = new Panel();
            label4 = new Label();
            txtSearch = new TextBox();
            pnlResultats = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlResultats.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SASSA);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.MidnightBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 83);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1003, 118);
            panel2.TabIndex = 1;
            // 
            // SASSA
            // 
            SASSA.AutoSize = true;
            SASSA.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SASSA.ForeColor = Color.White;
            SASSA.Location = new Point(12, 9);
            SASSA.Name = "SASSA";
            SASSA.Size = new Size(100, 38);
            SASSA.TabIndex = 0;
            SASSA.Text = "SASSA";
            SASSA.Click += SASSA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(22, 47);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Staff Console";
            // 
            // btnSignOut
            // 
            btnSignOut.Location = new Point(852, 25);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(112, 34);
            btnSignOut.TabIndex = 2;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 25);
            label3.Name = "label3";
            label3.Size = new Size(255, 45);
            label3.TabIndex = 1;
            label3.Text = "Search Booking";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.ButtonHighlight;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(label4);
            pnlSearch.Location = new Point(0, 191);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1001, 145);
            pnlSearch.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 0;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(65, 69);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Reference number ,name ,ID or phone...";
            txtSearch.Size = new Size(696, 41);
            txtSearch.TabIndex = 1;
            // 
            // pnlResultats
            // 
            pnlResultats.BackColor = SystemColors.ButtonFace;
            pnlResultats.Controls.Add(label5);
            pnlResultats.Location = new Point(0, 335);
            pnlResultats.Name = "pnlResultats";
            pnlResultats.Size = new Size(1001, 248);
            pnlResultats.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 15);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 0;
            label5.Text = "Search Result";
            // 
            // StaffQueueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1001, 639);
            Controls.Add(pnlResultats);
            Controls.Add(pnlSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StaffQueueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Queue Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlResultats.ResumeLayout(false);
            pnlResultats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel panel1;
        private Label SASSA;
        private Panel panel2;
        private Label label1;
        private Button btnSignOut;
        private Label label2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlSearch;
        private Label label4;
        private TextBox txtSearch;
        private Panel pnlResultats;
        private Label label5;
    }
}