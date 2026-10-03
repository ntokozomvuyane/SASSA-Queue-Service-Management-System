using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string identifier = txtUsername.Text.Trim();
            string fullname = txtFullName.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(identifier) ||
                string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please complete all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (newPassword.Length < 4)
            {
                MessageBox.Show("The password must contain at least 4 characters.",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The passwords do not match.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }
            User? account = UserRepository.Users.FirstOrDefault(user =>
            {
                bool identifierMatches =
                    string.Equals(user.Username, identifier,
                        StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(user.UserID, identifier,
                        StringComparison.OrdinalIgnoreCase) ||
                    (user is StaffMember staff &&
                     string.Equals(staff.StaffID, identifier,
                        StringComparison.OrdinalIgnoreCase)) ||
                    (user is Administrator administrator &&
                     string.Equals(administrator.EmployeeNumber, identifier,
                        StringComparison.OrdinalIgnoreCase));

                return identifierMatches &&
                    string.Equals(user.FullName, fullname,
                        StringComparison.OrdinalIgnoreCase);
            });

            if (account == null)
            {
                MessageBox.Show("No account matches that identifier and email.",
                    "Account Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            account.Password = newPassword;

            MessageBox.Show("Your password was reset successfully.",
                "Password Reset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
        private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hideNewPassword = !chkShowNewPassword.Checked;
            txtNewPassword.UseSystemPasswordChar = hideNewPassword;
            
        }
        private void chkShowConfirmedPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hideConfirmedPassword = !chkShowConfirmedPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = hideConfirmedPassword;
        }
        private void chkShowUsername_CheckedChanged(object sender, EventArgs e)
        {
            bool hideUsername = !chkShowUsername.Checked;
            txtUsername.UseSystemPasswordChar = hideUsername;
            
        }
        private void chkShowFullName_CheckedChanged(object sender, EventArgs e)
        {
            bool hideFullName = !chkShowFullName.Checked;
            txtFullName.UseSystemPasswordChar = hideFullName;
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
