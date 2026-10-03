namespace SASSAQueueManagementSystem
{
    partial class Completed_Services
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
            lblReports = new Label();
            button6 = new Button();
            btnDailyBookings = new Button();
            btnNoShows = new Button();
            btnDemandByService = new Button();
            btnCompletedServices = new Button();
            dataGridView1 = new DataGridView();
            pnlCompletedServices = new FlowLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlCompletedServices.SuspendLayout();
            SuspendLayout();
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.BackColor = Color.Transparent;
            lblReports.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReports.ForeColor = Color.Black;
            lblReports.Location = new Point(215, 67);
            lblReports.Margin = new Padding(2, 0, 2, 0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(94, 30);
            lblReports.TabIndex = 0;
            lblReports.Text = "Reports";
            // 
            // button6
            // 
            button6.Location = new Point(767, 65);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(73, 30);
            button6.TabIndex = 3;
            button6.Text = "Sign Out";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnDailyBookings
            // 
            btnDailyBookings.BackColor = Color.FromArgb(0, 51, 110);
            btnDailyBookings.ForeColor = Color.White;
            btnDailyBookings.Location = new Point(215, 107);
            btnDailyBookings.Margin = new Padding(2);
            btnDailyBookings.Name = "btnDailyBookings";
            btnDailyBookings.Size = new Size(146, 34);
            btnDailyBookings.TabIndex = 8;
            btnDailyBookings.Text = "Daily Bookings";
            btnDailyBookings.UseVisualStyleBackColor = false;
            // 
            // btnNoShows
            // 
            btnNoShows.BackColor = Color.FromArgb(0, 51, 110);
            btnNoShows.ForeColor = Color.White;
            btnNoShows.Location = new Point(504, 107);
            btnNoShows.Margin = new Padding(2);
            btnNoShows.Name = "btnNoShows";
            btnNoShows.Size = new Size(139, 34);
            btnNoShows.TabIndex = 9;
            btnNoShows.Text = "No-Shows";
            btnNoShows.UseVisualStyleBackColor = false;
            // 
            // btnDemandByService
            // 
            btnDemandByService.BackColor = Color.FromArgb(0, 51, 110);
            btnDemandByService.ForeColor = Color.White;
            btnDemandByService.Location = new Point(647, 107);
            btnDemandByService.Margin = new Padding(2);
            btnDemandByService.Name = "btnDemandByService";
            btnDemandByService.Size = new Size(148, 34);
            btnDemandByService.TabIndex = 10;
            btnDemandByService.Text = "Demand by Service";
            btnDemandByService.UseVisualStyleBackColor = false;
            // 
            // btnCompletedServices
            // 
            btnCompletedServices.BackColor = Color.FromArgb(0, 51, 110);
            btnCompletedServices.ForeColor = Color.AliceBlue;
            btnCompletedServices.Location = new Point(365, 107);
            btnCompletedServices.Margin = new Padding(2);
            btnCompletedServices.Name = "btnCompletedServices";
            btnCompletedServices.Size = new Size(135, 34);
            btnCompletedServices.TabIndex = 11;
            btnCompletedServices.Text = "Completed Services";
            btnCompletedServices.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 17);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(606, 223);
            dataGridView1.TabIndex = 12;
            // 
            // pnlCompletedServices
            // 
            pnlCompletedServices.BorderStyle = BorderStyle.Fixed3D;
            pnlCompletedServices.Controls.Add(label5);
            pnlCompletedServices.Controls.Add(dataGridView1);
            pnlCompletedServices.Location = new Point(211, 145);
            pnlCompletedServices.Margin = new Padding(2);
            pnlCompletedServices.Name = "pnlCompletedServices";
            pnlCompletedServices.Size = new Size(629, 259);
            pnlCompletedServices.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 0;
            label5.Text = "Completed Services";
            // 
            // Completed_Services
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(button6);
            Controls.Add(pnlCompletedServices);
            Controls.Add(btnCompletedServices);
            Controls.Add(btnDemandByService);
            Controls.Add(btnNoShows);
            Controls.Add(btnDailyBookings);
            Controls.Add(lblReports);
            Margin = new Padding(2);
            Name = "Completed_Services";
            Text = "Completed_Services";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlCompletedServices.ResumeLayout(false);
            pnlCompletedServices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReports;
        private Button button6;
        private Button btnDailyBookings;
        private Button btnNoShows;
        private Button btnDemandByService;
        private Button btnCompletedServices;
        private DataGridView dataGridView1;
        private FlowLayoutPanel pnlCompletedServices;
        private Label label5;
    }
}