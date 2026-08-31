namespace Sassa_Queue_And_Service_Management_System
{
    partial class staffForm
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
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.btnCallNext = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnNo_Show = new System.Windows.Forms.Button();
            this.lblCurrently = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.pnlQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Location = new System.Drawing.Point(422, 87);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.RowHeadersWidth = 62;
            this.dgvQueue.RowTemplate.Height = 28;
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.Size = new System.Drawing.Size(958, 302);
            this.dgvQueue.TabIndex = 0;
            // 
            // pnlQueue
            // 
            this.pnlQueue.Controls.Add(this.btnNo_Show);
            this.pnlQueue.Controls.Add(this.btnComplete);
            this.pnlQueue.Controls.Add(this.btnCallNext);
            this.pnlQueue.Location = new System.Drawing.Point(406, 421);
            this.pnlQueue.Name = "pnlQueue";
            this.pnlQueue.Size = new System.Drawing.Size(974, 148);
            this.pnlQueue.TabIndex = 1;
            this.pnlQueue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQueue_Paint);
            // 
            // btnCallNext
            // 
            this.btnCallNext.Location = new System.Drawing.Point(73, 54);
            this.btnCallNext.Name = "btnCallNext";
            this.btnCallNext.Size = new System.Drawing.Size(145, 61);
            this.btnCallNext.TabIndex = 0;
            this.btnCallNext.Text = "Call Next";
            this.btnCallNext.UseVisualStyleBackColor = true;
            this.btnCallNext.Click += new System.EventHandler(this.btnCallNext_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(455, 54);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(133, 61);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnNo_Show
            // 
            this.btnNo_Show.Location = new System.Drawing.Point(689, 54);
            this.btnNo_Show.Name = "btnNo_Show";
            this.btnNo_Show.Size = new System.Drawing.Size(140, 61);
            this.btnNo_Show.TabIndex = 2;
            this.btnNo_Show.Text = "No_Show";
            this.btnNo_Show.UseVisualStyleBackColor = true;
            this.btnNo_Show.Click += new System.EventHandler(this.btnNo_Show_Click);
            // 
            // lblCurrently
            // 
            this.lblCurrently.AutoSize = true;
            this.lblCurrently.Location = new System.Drawing.Point(267, 56);
            this.lblCurrently.Name = "lblCurrently";
            this.lblCurrently.Size = new System.Drawing.Size(133, 20);
            this.lblCurrently.TabIndex = 2;
            this.lblCurrently.Text = "CurrentlyServing: ";
            // 
            // staffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 645);
            this.Controls.Add(this.lblCurrently);
            this.Controls.Add(this.pnlQueue);
            this.Controls.Add(this.dgvQueue);
            this.Name = "staffForm";
            this.Text = "staffForm";
            this.Load += new System.EventHandler(this.staffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.pnlQueue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Panel pnlQueue;
        private System.Windows.Forms.Button btnNo_Show;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCallNext;
        private System.Windows.Forms.Label lblCurrently;
    }
}