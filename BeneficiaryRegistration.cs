using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class BeneficiaryRegistration : Form
    {
        public BeneficiaryRegistration()
        {
            InitializeComponent();
        }

            private void btnCreateAccount_Click(object sender, EventArgs e)
            {
                string fullName = txtFullName.Text.Trim();
                string beneficiaryID = txtBeneficiaryID.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(fullName) ||
                    string.IsNullOrWhiteSpace(beneficiaryID) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show(
                        "Please complete all the fields.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!beneficiaryID.All(char.IsDigit))
                {
                    MessageBox.Show(
                        "The Beneficiary ID must contain numbers only.",
                        "Invalid Beneficiary ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtBeneficiaryID.Focus();
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show(
                        "Please enter a valid email address.",
                        "Invalid Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show(
                        "The password must contain at least 6 characters.",
                        "Invalid Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show(
                        "The passwords do not match.",
                        "Password Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtConfirmPassword.Clear();
                    txtConfirmPassword.Focus();
                    return;
                }
                bool accountExists = UserRepository.Users.Any(user =>
               user.UserID.Equals(
                   beneficiaryID,
                   StringComparison.OrdinalIgnoreCase) ||
               user.Username.Equals(
                   email,
                   StringComparison.OrdinalIgnoreCase));

                if (accountExists)
                {
                    MessageBox.Show(
                        "An account with this Beneficiary ID or email already exists.",
                        "Account Already Exists",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Beneficiary newBeneficiary = new Beneficiary
                {
                    UserID = beneficiaryID,
                    FullName = fullName,
                    Username = email,
                    Password = password
                };

                UserRepository.Users.Add(newBeneficiary);

                MessageBox.Show(
                    "Your account was created successfully. You can now log in.",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }
    }






        
