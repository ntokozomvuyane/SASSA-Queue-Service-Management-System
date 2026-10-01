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
    public partial class frmMyBookings : Form
    {
        private Beneficiary? currentBeneficiary;
        private Booking? bookingBeingRescheduled;
        public frmMyBookings()
        {

            InitializeComponent();
        }

        // Receives the beneficiary who logged in.
        public frmMyBookings(Beneficiary beneficiary) : this()
        {
            currentBeneficiary = beneficiary;
        }

        private void MyBookingsForm_Load(object sender, EventArgs e)
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

            ConfigureBookingGrid(dgvUpcoming);
            ConfigureBookingGrid(dgvPrevious);

            dtpRescheduleDate.MinDate = DateTime.Today.AddDays(1);
            pnlReschedule.Visible = false;

            LoadBookings();
        }

        private void ConfigureBookingGrid(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns.Add("Reference", "Reference Number");
            grid.Columns.Add("Service", "Service");
            grid.Columns.Add("Centre", "Service Centre");
            grid.Columns.Add("Appointment", "Date and Time");
            grid.Columns.Add("Status", "Status");
        }

        private void LoadBookings()
        {
            dgvUpcoming.Rows.Clear();
            dgvPrevious.Rows.Clear();

            if (currentBeneficiary == null)
            {
                return;
            }

            var beneficiaryBookings = SystemData.Bookings
                .Where(booking =>
                    booking.Beneficiary != null &&
                    booking.Beneficiary.UserID ==
                        currentBeneficiary.UserID)
                .OrderBy(booking =>
                    booking.TimeSlot.AppointmentDateTime)
                .ToList();

            foreach (Booking booking in beneficiaryBookings)
            {
                bool terminalStatus =
                    booking.Status == BookingStatus.Completed ||
                    booking.Status == BookingStatus.Cancelled ||
                    booking.Status == BookingStatus.NoShow;

                bool isUpcoming =
                    booking.TimeSlot.AppointmentDateTime >= DateTime.Now &&
                    !terminalStatus;

                if (isUpcoming)
                {
                    AddBookingRow(dgvUpcoming, booking);
                }
                else
                {
                    AddBookingRow(dgvPrevious, booking);
                }
            }

            btnCancelBooking.Enabled =
                dgvUpcoming.Rows.Count > 0;
            btnRescheduleBooking.Enabled =
                dgvUpcoming.Rows.Count > 0;
        }

        private void AddBookingRow(
            DataGridView grid, Booking booking)
        {
            int rowIndex = grid.Rows.Add(
                booking.ReferenceNumber,
                booking.Service.ServiceName,
                booking.ServiceCentre.CentreName,
                booking.TimeSlot.AppointmentDateTime
                    .ToString("dd MMMM yyyy HH:mm"),
                booking.Status.ToString());

            grid.Rows[rowIndex].Tag = booking;
        }

        private Booking? GetSelectedUpcomingBooking()
        {
            if (dgvUpcoming.CurrentRow == null)
            {
                return null;
            }

            return dgvUpcoming.CurrentRow.Tag as Booking;
        }

        private void btnCancelBooking_Click(
            object sender, EventArgs e)
        {
            Booking? selectedBooking =
                GetSelectedUpcomingBooking();

            if (selectedBooking == null)
            {
                MessageBox.Show(
                    "Please select an upcoming booking.",
                    "No Booking Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (selectedBooking.Status != BookingStatus.Booked)
            {
                MessageBox.Show(
                    "Only a booking with Booked status can be cancelled.",
                    "Cancellation Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to cancel booking " +
                selectedBooking.ReferenceNumber + "?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            if (selectedBooking.CancelBooking())
            {
                MessageBox.Show(
                    "The booking was cancelled successfully.",
                    "Booking Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                pnlReschedule.Visible = false;
                LoadBookings();
            }
        }

        private void btnRescheduleBooking_Click(
            object sender, EventArgs e)
        {
            Booking? selectedBooking =
                GetSelectedUpcomingBooking();

            if (selectedBooking == null)
            {
                MessageBox.Show(
                    "Please select an upcoming booking.",
                    "No Booking Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (selectedBooking.Status != BookingStatus.Booked)
            {
                MessageBox.Show(
                    "Only a booking with Booked status can be rescheduled.",
                    "Reschedule Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bookingBeingRescheduled = selectedBooking;
            dtpRescheduleDate.Value = DateTime.Today.AddDays(1);
            pnlReschedule.Visible = true;
            RefreshRescheduleSlots();
        }

        private void RefreshRescheduleSlots()
        {
            cboRescheduleTimeSlot.DataSource = null;

            if (bookingBeingRescheduled == null)
            {
                lblRescheduleAvailability.Text =
                    "Select a booking first";
                return;
            }

            var availableSlots = SystemData.TimeSlots
                .Where(slot =>
                    slot.CentreID ==
                        bookingBeingRescheduled
                            .ServiceCentre.CentreID &&
                    slot.Date.Date ==
                        dtpRescheduleDate.Value.Date &&
                    slot.SlotID !=
                        bookingBeingRescheduled.TimeSlot.SlotID &&
                    slot.CheckAvailability())
                .ToList();

            cboRescheduleTimeSlot.DataSource = availableSlots;

            lblRescheduleAvailability.Text =
                availableSlots.Count == 0
                    ? "No available slots for this date"
                    : availableSlots.Count +
                      " available slot(s)";
        }

        private void dtpRescheduleDate_ValueChanged(
            object sender, EventArgs e)
        {
            RefreshRescheduleSlots();
        }

        private void btnConfirmReschedule_Click(
            object sender, EventArgs e)
        {
            if (bookingBeingRescheduled == null)
            {
                return;
            }

            if (cboRescheduleTimeSlot.SelectedItem
                is not TimeSlot selectedSlot)
            {
                MessageBox.Show(
                    "Please select an available time slot.",
                    "No Time Slot Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool duplicateBooking = SystemData.Bookings.Any(
                booking =>
                    booking != bookingBeingRescheduled &&
                    booking.Beneficiary.UserID ==
                        currentBeneficiary!.UserID &&
                    booking.TimeSlot.AppointmentDateTime ==
                        selectedSlot.AppointmentDateTime &&
                    booking.Status != BookingStatus.Cancelled);

            if (duplicateBooking)
            {
                MessageBox.Show(
                    "You already have another booking for this date and time.",
                    "Duplicate Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!bookingBeingRescheduled
                    .RescheduleBooking(selectedSlot))
            {
                MessageBox.Show(
                    "The selected time slot is no longer available.",
                    "Reschedule Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                RefreshRescheduleSlots();
                return;
            }

            MessageBox.Show(
                "The booking was rescheduled successfully.",
                "Booking Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            bookingBeingRescheduled = null;
            pnlReschedule.Visible = false;
            LoadBookings();
        }

        private void btnCloseReschedule_Click(
            object sender, EventArgs e)
        {
            bookingBeingRescheduled = null;
            pnlReschedule.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string NextPage { get; private set; } = "";
            private void GoToPage(string page)
        {
            NextPage = page;
            Close();
        }
        private void btnDashboard_Click(object sender, EventArgs e) => Close();
        private void btnNewBooking_Click(object sender, EventArgs e) => GoToPage("NewBooking");
        private void btnMyBooking_Click(object sender, EventArgs e) { } // Already here.
        private void btnQueueStatus_Click(object sender, EventArgs e) => GoToPage("QueueStatus");
        private void btnProfile_Click(object sender, EventArgs e) => GoToPage("Profile");
        private void btnSignOut_Click(object sender, EventArgs e) => GoToPage("Logout");
    

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            if(currentBeneficiary == null)
            {
                MessageBox.Show("Please log in first");
                return;
            }
            using (var form = new frmMyBookings(currentBeneficiary))
            {
                form.ShowDialog(this);
                //after dialog closes, use the dashboard's existing navigation

                switch (form.NextPage)
                {
                    case "NewBooking": btnNewBooking_Click(sender, EventArgs.Empty); break;
                    case "QueueStatus": btnQueueStatus_Click(sender, EventArgs.Empty); break;
                    case "Profile": btnProfile_Click(sender, EventArgs.Empty); break;
                    case "Logout": btnSignOut_Click(sender, EventArgs.Empty); break;
                }

            }
        }
        }
    }




