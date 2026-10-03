using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SASSAQueueManagementSystem
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }
        //private void StaffLogin_Load(object sender, EventArgs e)
        //{
        //    txtPassword.UseSystemPasswordChar = true;
        //    AcceptButton = btnLogin;

        //    // Protected pages must not open before authentication.
        //    btnDashboard.Enabled = false;
        //    btnQueueOverview.Enabled = false;
        //    btnProfile.Enabled = false;

        //    txtStaffID.Focus();
        //}
        //private void ClearFields()
        //{
        //    txtStaffID.Clear();
        //    txtPassword.Clear();
        //    txtStaffID.Focus();
        //}

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    ClearFields();
        //}

        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    // No staff member is logged in yet, so this acts as Back.
        //    Close();
        //}
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string staffID = txtStaffID.Text.Trim();
        //    string password = txtPassword.Text;

        //    if (string.IsNullOrWhiteSpace(staffID))
        //    {
        //        MessageBox.Show(
        //            "Please enter your Staff ID.",
        //            "Missing Staff ID",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning);
        //        txtStaffID.Focus();
        //        return;
        //    }

        //    if (string.IsNullOrWhiteSpace(password))
        //    {
        //        MessageBox.Show(
        //            "Please enter your password.",
        //            "Missing Password",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning);
        //        txtPassword.Focus();
        //        return;
        //    }

        //    StaffMember? loggedInStaff = UserRepository.Users
        //               .OfType<StaffMember>()
        //               .FirstOrDefault(staff =>
        //                   (staff.StaffID.Equals(
        //                        staffID,
        //                        StringComparison.OrdinalIgnoreCase) ||
        //                    staff.UserID.Equals(
        //                        staffID,
        //                        StringComparison.OrdinalIgnoreCase)) &&
        //                   staff.Password == password);

        //    if (loggedInStaff == null)
        //    {
        //        MessageBox.Show(
        //            "The Staff ID or password is incorrect.",
        //            "Login Failed",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //        txtPassword.Clear();
        //        txtPassword.Focus();
        //        return;
        //    }

        //    MessageBox.Show(
        //       "Welcome, " + loggedInStaff.FullName + "!",
        //       "Login Successful",
        //       MessageBoxButtons.OK,
        //       MessageBoxIcon.Information);

        //    Hide();
        //    using (var dashboard = new StaffDashboard(loggedInStaff))
        //    {
        //        dashboard.ShowDialog(this);
        //    }

        //    // StaffDashboard closes when the staff member signs out.
        //    // Closing StaffLogin returns to the Welcome page.
        //    Close();

        //}
    }
}


    
