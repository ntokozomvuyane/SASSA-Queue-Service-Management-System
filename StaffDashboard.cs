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

