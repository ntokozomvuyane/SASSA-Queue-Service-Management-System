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

        // This constructor allows the Windows Forms Designer to open.
        public Login()
        {
            InitializeComponent();
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
                    user.Role == selectedRole &&
                    user.ValidateLogin(username, password));

            if (loggedInUser == null)
            {
                MessageBox.Show(
                    "Invalid username or password for the " +
                    "selected login type.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            if (loggedInUser is Beneficiary beneficiary)
            {
                MessageBox.Show(
                    "Welcome, " + loggedInUser.FullName + "!",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                using (BeneficiaryDashboard dashboard = new BeneficiaryDashboard(beneficiary))
                {
                    dashboard.ShowDialog();
                }

                this.Close();
                // before adding using OpenDashboard(loggedInUser);
            }
        }

        private void OpenDashboard(User loggedInUser)
        {
            Form dashboard;

            switch (loggedInUser.Role)
            {
                case UserRole.Staff:
                    dashboard = new StaffDashboard();
                    break;

                case UserRole.Administrator:
                    dashboard = new frmAdministration();
                    break;

                default:
                    dashboard = new BeneficiaryDashboard(
                        (Beneficiary)loggedInUser);
                    break;
            }

            this.Hide();
            dashboard.ShowDialog();
            this.Close();
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
            using (BeneficiaryRegistration registrationForm =
                   new BeneficiaryRegistration())
            {
                registrationForm.ShowDialog();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetMenuButtons(false);
        }
    }
}





