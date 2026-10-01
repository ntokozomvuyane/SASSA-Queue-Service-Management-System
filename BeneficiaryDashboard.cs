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
    public partial class BeneficiaryDashboard : Form
    {
        private Beneficiary? currentBeneficiary;
        private string beneficiaryID = "";
        private string beneficiaryName = "";
        public BeneficiaryDashboard()
        {
            InitializeComponent();
        }
        public BeneficiaryDashboard(Beneficiary beneficiary) :this()
        {
            currentBeneficiary = beneficiary;
        }
        private void BeneficiaryDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardInformation();
        }
        public void LoadDashboardInformation()
        {
            lblUpcomingAppointment.Text = "20 September 2026";
            lbltotalBookings.Text = "2";
            lblQueuePosition.Text = "Not checked in";
            lblUnreadNotifications.Text = "0";
        }

        private void OpenNewBooking()
        {
            MessageBox.Show("The New Booking form will open here.", "New Booking", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            NewBookingForm bookingForm = new NewBookingForm();
            bookingForm.ShowDialog();
            LoadDashboardInformation();
        }
        private void OpenMyBookings()
        {
            MessageBox.Show("The My Bookings form will open here.", "My Bookings", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //After the mybookings form has been created:
             frmMyBookings bookingForm = new frmMyBookings();
            bookingForm.ShowDialog();
            LoadDashboardInformation();
        }
        private void OpenQueueStatus()
        {
            MessageBox.Show("The Queue Status form will open here.", "Queue Status",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            QueueStatusForm queueForm = new QueueStatusForm();
            queueForm.ShowDialog();
            LoadDashboardInformation();
        }

        private void OpenProfile()
        {
            MessageBox.Show($"Beneficiary: {beneficiaryName}\n" + $"Beneficiary ID:{beneficiaryID}",
                "Beneficiary Profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //After profile form has been created
            MyProfileForm profileForm = new MyProfileForm();
            profileForm.ShowDialog();
        }
        private void btnbookingnewappointment_Click(object sender, EventArgs e)
        {
            // before it was this OpenNewBooking();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("No beneficiary is" +
                    "currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (NewBookingForm bookingForm =
                new NewBookingForm(currentBeneficiary))
            {
                bookingForm.ShowDialog(this);

                switch (bookingForm.NextPage) 
                {
                    case "MyBookings":
                        using (frmMyBookings form = new frmMyBookings(currentBeneficiary))
                            form.ShowDialog(this);
                        break;

                    case "QueueStatus":
                        using (QueueStatusForm form = new QueueStatusForm(currentBeneficiary))
                            form.ShowDialog(this);
                        break;

                    case "Profile":
                       using (MyProfileForm form = new MyProfileForm(currentBeneficiary))
                          form.ShowDialog(this);
                       break;

                    case "Logout":
                        Close();
                        break;


                }
            }
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            //before it was this OpenNewBooking()
            if(currentBeneficiary == null)
            {
                MessageBox.Show("No beneficiary is" +
                    "currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (NewBookingForm bookingForm =
                new NewBookingForm(currentBeneficiary))
            {
                bookingForm.ShowDialog();
            }
            }

        private void btnpersonalBooking_Click(object sender, EventArgs e)
        {
            // Before OpenMyBookings();
            if(currentBeneficiary == null)
            {
                MessageBox.Show("No beneficiary is currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (frmMyBookings bookingForm = new
                frmMyBookings(currentBeneficiary))
            {
                bookingForm.ShowDialog();
            }
        }

        private void btnMyBooking_Click(object sender, EventArgs e)
        {
            //OpenMyBookings();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("No beneficiary is currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (frmMyBookings bookingForm = new
                frmMyBookings(currentBeneficiary))
            {
                bookingForm.ShowDialog();
            }
        }

        private void btnViewAppointmentDetails_Click(object sender, EventArgs e)
        {

            OpenMyBookings();
        }

        private void btnViewBookingDetails_Click(object sender, EventArgs e)
        {

            OpenMyBookings();
        }

        private void btnQueuePosition_Click(object sender, EventArgs e)
        {
            // Before OpenQueueStatus();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("No beneficiary is currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            using (QueueStatusForm queueStatusForm =
                new QueueStatusForm(currentBeneficiary))
            {
                queueStatusForm.ShowDialog();
            }
        }

        private void btnQueueStatus_Click(object sender, EventArgs e)
        {
            //OpenQueueStatus();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("Please log in first.");
                return;
            }
            string nextPage;
            using (var form =
                new QueueStatusForm(currentBeneficiary))
            {
                form.ShowDialog(this);
                nextPage = form.NextPage;
            }
            switch (nextPage)
            {
                case "NewBooking":
                    btnNewBooking_Click(sender, EventArgs.Empty);
                    break;
                case "MyBookings":
                    btnMyBooking_Click(sender, EventArgs.Empty);
                    break;
                case "Profile":
                    btnProfile_Click(sender, EventArgs.Empty);
                    break;
                case "Logout":
                    btnLogout_Click(sender, EventArgs.Empty);
                    break;
                    // Empty string means Dashboard or the window X: stay here.

            }
        }

        private void btnViewQueue_Click(object sender, EventArgs e)
        {
            OpenQueueStatus();
        }

        private void btnpersonalDetails_Click(object sender, EventArgs e)
        {
            //OpenProfile();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("Please sign in again.");
                return;
            }

            using (var form = new MyProfileForm(currentBeneficiary))
            {
                form.ShowDialog(this);
                string nextPage = form.NextPage;
                if (nextPage == "NewBooking")
                    btnNewBooking_Click(sender, EventArgs.Empty);
                else if (nextPage == "MyBookings")
                    btnMyBooking_Click(sender, EventArgs.Empty);
                else if (nextPage == "QueueStatus")
                    btnQueueStatus_Click(sender, EventArgs.Empty);
                else if (nextPage == "SignOut")
                    btnLogout_Click(sender, EventArgs.Empty);
            }


        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //OpenProfile();
            if (currentBeneficiary == null)
            {
                MessageBox.Show("Please sign in again.");
                return;
            }

            using (var form = new MyProfileForm(currentBeneficiary))
            {
                form.ShowDialog(this);
                string nextPage = form.NextPage;
                if (nextPage == "NewBooking")
                    btnNewBooking_Click(sender, EventArgs.Empty);
                else if (nextPage == "MyBookings")
                    btnMyBooking_Click(sender, EventArgs.Empty);
                else if (nextPage == "QueueStatus")
                    btnQueueStatus_Click(sender, EventArgs.Empty);
                else if (nextPage == "SignOut")
                    btnLogout_Click(sender, EventArgs.Empty);
            }



        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardInformation();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have no unread notifications.", "Notifications",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?",
                "Confirm logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            new WelcomePage().Show();
                this.Close();
            }
        }
    }

