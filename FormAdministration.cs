using Sassa_Queue_And_Service_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Zanele_Admin;
using Zanele_Admin_BookingManagement;

namespace SASSAQueueManagementSystem
{
    public partial class frmAdministration : Form
    {
        private Administrator? currentAdministrator;
        public frmAdministration()
        {
            InitializeComponent();
        }
        public frmAdministration(Administrator administrator) : this()
        {
            currentAdministrator = administrator;
            ShowDashboardHome();
        }

        private Form? activeChildForm;
        private bool changingChildForm;

        private void OpenChildForm(Form childForm)
        {
            changingChildForm = true;

            if (activeChildForm != null)
            {
                activeChildForm.FormClosed -= ActiveChildForm_FormClosed;
                activeChildForm.Close();
            }

            pnlContent.Controls.Clear();

            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.FormClosed += ActiveChildForm_FormClosed;

            pnlContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            changingChildForm = false;
        }

        private void ActiveChildForm_FormClosed(object? sender,
            FormClosedEventArgs e)
        {
            if (changingChildForm)
            {
                return;
            }

            activeChildForm = null;
            ShowDashboardHome();
        }
        private void ShowDashboardHome()
        {
            changingChildForm = true;

            if (activeChildForm != null)
            {
                activeChildForm.FormClosed -= ActiveChildForm_FormClosed;
                activeChildForm.Close();
                activeChildForm = null;
            }

            pnlContent.Controls.Clear();
            pnlDashboardHome.Dock = DockStyle.Fill;
            pnlDashboardHome.Visible = true;
            pnlContent.Controls.Add(pnlDashboardHome);
            pnlDashboardHome.BringToFront();

            changingChildForm = false;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardHome();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            if (currentAdministrator == null) return;
            OpenChildForm(new frmServices(currentAdministrator));
        }
        private void btnSlots_Click(object sender, EventArgs e)
        {
            if (currentAdministrator == null) return;
            OpenChildForm(new frmAppointmentSlots(currentAdministrator));
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            if (currentAdministrator == null) return;
            OpenChildForm(new frmBookings(currentAdministrator));
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (currentAdministrator == null) return;
            OpenChildForm(new Admin_Reports(currentAdministrator));
        }

        //private void btnProfile_Click(object sender, EventArgs e)
        //{
        //    if (currentAdministrator == null) return;
        //    OpenChildForm(new AdminProfileForm(currentAdministrator));
        //}
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                Close();
            }
        }


    }
}
