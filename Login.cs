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
    public partial class Login : Form
    {
        private UserRole selectedRole = UserRole.Beneficiary;
        //private UserRole selectedRole = UserRole.Staff;


        // This constructor allows the Windows Forms Designer to open.
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        // This constructor receives the role selected on WelcomePage.
        public Login(UserRole role) : this()
        {
            selectedRole = role;
            lblLoginHeading.Text = GetRoleName(role) + " Login";
            btnCreateAccount.Visible = role == UserRole.Beneficiary;
        }

        private string GetRoleName(UserRole role)
        {
            if (role == UserRole.Staff)
            {
                return "Staff";
            }

            if (role == UserRole.Administrator)
            {
                return "Administrator";
            }

            return "Beneficiary";
        }
        private void SetMenuButtons(bool enabled)
        {
            btnDashboard.Enabled = enabled;
            btnNewBooking.Enabled = enabled;
            btnMyBooking.Enabled = enabled;
            btnQueueStatus.Enabled = enabled;
            btnProfile.Enabled = enabled;
            btnSignOut.Enabled = enabled;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Missing Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            User? loggedInUser = UserRepository.Users
                .FirstOrDefault(user =>
                    MatchesUsername(user, username) &&
                    user.Password == password);

            if (loggedInUser == null)
            {
                MessageBox.Show(
                    "The login details are incorrect ",
                    "Login failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            //before
            //if (loggedInUser is Beneficiary beneficiary)
            //{
            //    MessageBox.Show(
            //        "Welcome, " + loggedInUser.FullName + "!",
            //        "Login Successful",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);

            //    this.Hide();

            //    using (BeneficiaryDashboard dashboard = new BeneficiaryDashboard(beneficiary))
            //    {
            //        dashboard.ShowDialog();
            //    }

            //    this.Close();
            OpenCorrectDashboard(loggedInUser);
        }


        private void OpenCorrectDashboard(User loggedInUser)
        {
            Form dashboard;

            if (loggedInUser is Beneficiary beneficiary)
            {
                dashboard = new BeneficiaryDashboard(beneficiary);
            }
            else if (loggedInUser is StaffMember staffMember)
            {
                dashboard = new StaffDashboard(staffMember);
            }
            else if (loggedInUser is Administrator administrator)
            {
                dashboard = new frmAdministration(administrator);
            }
            else
            {
                MessageBox.Show("This user type is not supported.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Hide();

            using (dashboard)
            {
                dashboard.ShowDialog(this);
            }

            txtUsername.Clear();
            txtPassword.Clear();
            Show();
            txtUsername.Focus();

        }

        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            txtUsername.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var registration =
                   new BeneficiaryRegistration())
            {
                registration.ShowDialog(this);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetMenuButtons(false);
        }
        //i named it matches username instead of matches login id
        private bool MatchesUsername(User user, string username)
        {
            if (string.Equals(user.Username, username,
                StringComparison.OrdinalIgnoreCase) ||
                string.Equals(user.UserID, username,
                StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (user is StaffMember staff &&
                string.Equals(staff.StaffID, username,
                StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (user is Administrator administrator &&
                string.Equals(administrator.EmployeeNumber, username,
                StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private void lnklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();

            using (var forgotPassword = new ForgotPassword())
            {
                forgotPassword.ShowDialog(this);
            }

            Show();
            Activate();
            txtPassword.Clear();
            txtPassword.Focus();

        }
    }
}





