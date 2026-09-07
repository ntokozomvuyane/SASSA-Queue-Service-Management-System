using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sassa_Queue_And_Service_Management_System
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(staffID) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your Staff ID and Password.",
                    "Missing Informayion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(staffID))
            {
                MessageBox.Show("Please enter your Staff ID.",
                    "Missing Staff ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your Password.",
                    "Missing Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (staffID == "STAFF001" && password == "12345")
            {
                MessageBox.Show("Login successful!");

                StaffDashboard dashboard = new StaffDashboard("Officer Bhengu", "Service Officer");
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Staff ID or Password.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            if (!staffID.StartsWith("STAFF") || staffID.Length != 8)
            {
                MessageBox.Show("Please enter a valid staff ID.",
                    "Invalid Staff ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtStaffID.Focus();
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Clear();
            txtPassword.Clear();

            txtStaffID.Focus();
        }
    }
}

