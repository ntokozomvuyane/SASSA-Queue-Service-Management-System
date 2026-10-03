using Sassa_Queue_And_Service_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class StaffDashboard : Form
    {
        private StaffMember? currentStaff;

        // Required by the Windows Forms Designer.
        public StaffDashboard()
        {
            InitializeComponent();
        }

        // Receives the staff member who logged in.
        public StaffDashboard(StaffMember staff) : this()
        {
            currentStaff = staff;
            ShowDashboardHome();
        }

        
        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            if (currentStaff == null)
            {
                MessageBox.Show(
                    "No staff member was supplied.",
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            lblStaffName.Text = currentStaff.FullName;
            lblStaffRole.Text = "Staff - " + currentStaff.ServiceCentre;
            lblCurrentDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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
        private void btnQueueOverview_Click(object sender, EventArgs e)
        {
            if (currentStaff == null) return;
            OpenChildForm(new frmQueueManagementSystem(currentStaff));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (currentStaff == null) return;
            OpenChildForm(new frmStaffProfile(currentStaff));
        }
        private void btnLogout_Click(object sender, EventArgs e)
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


        //StaffMember? loggedInStaff = UserRepository.Users
        //        .OfType<StaffMember>()
        //        .FirstOrDefault(staff =>
        //            (staff.StaffNumber.Equals(
        //                 staffID,
        //                 StringComparison.OrdinalIgnoreCase) ||
        //             staff.UserID.Equals(
        //                 staffID,
        //                 StringComparison.OrdinalIgnoreCase)) &&
        //            staff.Password == password);

        //        if (loggedInStaff == null)
        //        {
        //            MessageBox.Show(
        //                "The Staff ID or password is incorrect.",
        //                "Login Failed",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Error);
        //            txtPassword.Clear();
        //            txtPassword.Focus();
        //            return;
        //        }

        //MessageBox.Show(
        //            "Welcome, " + loggedInStaff.FullName + "!",
        //            "Login Successful",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);

        //        Hide();
        //        using (var dashboard = new StaffDashboard(loggedInStaff))
        //        {
        //            dashboard.ShowDialog(this);
        //}

        //// StaffDashboard closes when the staff member signs out.
        //// Closing StaffLogin returns to the Welcome page.
        //Close();
    }



}

