using SASSAQueueManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sassa_Queue_And_Service_Management_System
{
    public partial class MyProfileForm : Form
    {
        private Beneficiary? currentBeneficiary;
        public string NextPage { get; private set; } = "";
        public MyProfileForm()
        {
            InitializeComponent();
        }
        public MyProfileForm(Beneficiary beneficiary) : this()
        {
            currentBeneficiary = beneficiary;
        }

        private void BeneficiaryProfileForm_Load(object sender, EventArgs e)
        {
            if (currentBeneficiary == null)
            {
                MessageBox.Show("Please open profile after signing in.");
                Close();
                return;
            }
            cboPreferredCentre.DataSource = null;
            cboPreferredCentre.DataSource =
                SystemData.ServiceCentres.ToList();
            cboPreferredCentre.DisplayMember = "CentreName";
            cboPreferredCentre.ValueMember = "CentreID";


            txtFullName.Text = currentBeneficiary.FullName;
            txtUserID.Text = currentBeneficiary.UserID;
            txtUsername.Text = currentBeneficiary.Username;
            txtContactNumber.Text = currentBeneficiary.ContactNumber;

            //int index = SystemData.ServiceCentres.FindIndex(c =>
            //        c.CentreID == currentBeneficiary.PreferredCentreID);
            //cboPreferredCentre.SelectedIndex = index;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentBeneficiary == null)
                
            {
                MessageBox.Show("Please sign in again.");
                return;

            }

            string fullName = txtFullName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string email = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrEmpty(contactNumber) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter name, contact number" +
                    "and email.");
                return;
            }
            if (!System.Net.Mail.MailAddress.TryCreate(
            email, out var address) || address.Address != email)
            {
                MessageBox.Show("Enter a valid email address.");
                return;
            }

            bool emailUsed = UserRepository.Users.Any(u =>
                !ReferenceEquals(u, currentBeneficiary) &&
                u.Username.Equals(email,
                    StringComparison.OrdinalIgnoreCase));
            if (emailUsed)
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            if (cboPreferredCentre.SelectedItem is not ServiceCentre centre)
            {
                MessageBox.Show("Select a preferred centre.");
                return;
            }

            currentBeneficiary.FullName = fullName;
            currentBeneficiary.ContactNumber = contactNumber;
            currentBeneficiary.Username = email;
            //currentBeneficiary.PreferredCentreID = centre.CentreID;
            MessageBox.Show("Your profile has been updated.");
        }
        private void GoToPage(string page)
        {
            NextPage = page;
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Close(); // Return to the dashboard already open behind Profile.
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            GoToPage("NewBooking");
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            GoToPage("MyBookings");
        }

        private void btnQueueStatus_Click(object sender, EventArgs e)
        {
            GoToPage("QueueStatus");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // You are already on Profile.
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            GoToPage("SignOut");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            


        }
    }
}    
