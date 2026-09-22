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
    public partial class QueueStatusForm : Form
    {
        private Beneficiary? currentBeneficiary;
        private QueueEntry? currentQueueEntry;

        public QueueStatusForm()
        {
            InitializeComponent();
        }
        // Receives the beneficiary who logged in.
        public QueueStatusForm(Beneficiary beneficiary) : this()
        {
            currentBeneficiary = beneficiary;
        }

        private void QueueStatusForm_Load(object sender, EventArgs e)
        {
            if (currentBeneficiary == null)
            {
                MessageBox.Show(
                    "No beneficiary is currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            tmrQueueRefresh.Interval = 5000;
            tmrQueueRefresh.Start();
            DisplayQueueStatus();
        }

        private void DisplayQueueStatus()
        {
            if (currentBeneficiary == null)
            {
                return;
            }

            currentQueueEntry = SystemData.QueueEntries
                .Where(entry =>
                    entry.Booking != null &&
                    entry.Booking.Beneficiary.UserID ==
                        currentBeneficiary.UserID)
                .OrderByDescending(entry => entry.CheckInTime)
                .FirstOrDefault();

            if (currentQueueEntry == null)
            {
                pnlQueueDetails.Visible = false;
                lblQueueMessage.Visible = true;
                lblQueueMessage.Text =
                    "You do not have a queue entry yet. " +
                    "Please check in at the service centre.";
                return;
            }

            UpdateQueuePosition(currentQueueEntry);

            pnlQueueDetails.Visible = true;
            lblQueueMessage.Visible = true;

            lblQueueNumber.Text =
                currentQueueEntry.QueueNumber;

            lblCurrentStatus.Text =
                FormatQueueStatus(currentQueueEntry.Status);

            lblServiceName.Text =
                currentQueueEntry.Booking.Service.ServiceName;

            lblCentreName.Text =
                currentQueueEntry.Booking
                    .ServiceCentre.CentreName;

            lblCheckInTime.Text =
                currentQueueEntry.CheckInTime
                    .ToString("dd MMMM yyyy HH:mm");

            DisplayWaitingInformation(currentQueueEntry);
            lblQueueMessage.Text =
                GetStatusMessage(currentQueueEntry.Status);
        }

        private void UpdateQueuePosition(QueueEntry entry)
        {
            if (entry.Status != QueueStatus.CheckedIn &&
                entry.Status != QueueStatus.Waiting)
            {
                entry.PeopleAhead = 0;
                entry.EstimatedWaitingTime = 0;
                return;
            }

            int peopleAhead = SystemData.QueueEntries.Count(
                other =>
                    other != entry &&
                    other.Booking.ServiceCentre.CentreID ==
                        entry.Booking.ServiceCentre.CentreID &&
                    other.Booking.Service.ServiceID ==
                        entry.Booking.Service.ServiceID &&
                    other.CheckInTime < entry.CheckInTime &&
                    (other.Status == QueueStatus.CheckedIn ||
                     other.Status == QueueStatus.Waiting));

            entry.PeopleAhead = peopleAhead;

            // Prototype estimate: approximately 15 minutes per person.
            entry.EstimatedWaitingTime = peopleAhead * 15;
        }

        private void DisplayWaitingInformation(QueueEntry entry)
        {
            if (entry.Status == QueueStatus.CheckedIn ||
                entry.Status == QueueStatus.Waiting)
            {
                lblPeopleAhead.Text =
                    entry.PeopleAhead.ToString();

                lblEstimatedWait.Text =
                    entry.EstimatedWaitingTime + " minutes";
            }
            else if (entry.Status == QueueStatus.Called ||
                     entry.Status == QueueStatus.BeingServed)
            {
                lblPeopleAhead.Text = "0";
                lblEstimatedWait.Text =
                    "Proceed to the service desk";
            }
            else
            {
                lblPeopleAhead.Text = "0";
                lblEstimatedWait.Text = "Not applicable";
            }
        }

        private string FormatQueueStatus(QueueStatus status)
        {
            switch (status)
            {
                case QueueStatus.CheckedIn:
                    return "Checked In";

                case QueueStatus.BeingServed:
                    return "Being Served";

                case QueueStatus.NoShow:
                    return "No Show";

                default:
                    return status.ToString();
            }
        }

        private string GetStatusMessage(QueueStatus status)
        {
            switch (status)
            {
                case QueueStatus.CheckedIn:
                    return "Your check-in has been recorded.";

                case QueueStatus.Waiting:
                    return "Please remain in the waiting area.";

                case QueueStatus.Called:
                    return "Your queue number has been called.";

                case QueueStatus.BeingServed:
                    return "Your service is currently in progress.";

                case QueueStatus.Completed:
                    return "Your service has been completed.";

                case QueueStatus.NoShow:
                    return "This queue entry was marked as no-show.";

                default:
                    return "Queue information is being updated.";
            }
        }

        private void tmrQueueRefresh_Tick(
            object sender, EventArgs e)
        {
            DisplayQueueStatus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayQueueStatus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tmrQueueRefresh.Stop();
            Close();
        }
        public string NextPage { get; private set; } = "";

        private void GoToPage(string page)
        {
            NextPage = page;
            tmrQueueRefresh.Stop();
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tmrQueueRefresh.Stop();
            Close(); // Return to the dashboard.
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            GoToPage("NewBooking");
        }

        private void btnMyBooking_Click(object sender, EventArgs e)
        {
            GoToPage("MyBookings");
        }

        private void btnQueueStatus_Click(object sender, EventArgs e)
        {
            // Already viewing Queue Status.
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            GoToPage("Profile");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            GoToPage("Logout");
        }


    }
}

   