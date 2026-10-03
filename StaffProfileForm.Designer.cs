namespace SASSAQueueManagementSystem
{
    partial class frmStaffProfile
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
            lblStaffName = new Label();
            lblStaffID = new Label();
            lblServiceCentre = new Label();
            SuspendLayout();
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(88, 36);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(66, 15);
            lblStaffName.TabIndex = 0;
            lblStaffName.Text = "Staff Name";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Location = new Point(88, 75);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(45, 15);
            lblStaffID.TabIndex = 1;
            lblStaffID.Text = "Staff ID";
            // 
            // lblServiceCentre
            // 
            lblServiceCentre.AutoSize = true;
            lblServiceCentre.Location = new Point(88, 114);
            lblServiceCentre.Name = "lblServiceCentre";
            lblServiceCentre.Size = new Size(82, 15);
            lblServiceCentre.TabIndex = 2;
            lblServiceCentre.Text = "Service Centre";
            // 
            // frmStaffProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblServiceCentre);
            Controls.Add(lblStaffID);
            Controls.Add(lblStaffName);
            Name = "frmStaffProfile";
            Text = "StaffProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaffName;
        private Label lblStaffID;
        private Label lblServiceCentre;
    }
}