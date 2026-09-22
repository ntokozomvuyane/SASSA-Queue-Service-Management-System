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
    public partial class NewBookingForm : Form
    {
        private Beneficiary? currentBeneficiary;
        public NewBookingForm()
        {
            InitializeComponent();
        }
        public NewBookingForm(Beneficiary beneficiary) : this()
        {
            currentBeneficiary = beneficiary;
        }

        private void cboServiceCentre_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            RefreshAvailableSlots();
        }

        private void dtpBookingDate_ValueChanged(
            object sender, EventArgs e)
        {
            RefreshAvailableSlots();
        }

        private void cboTimeSlot_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cboTimeSlot.SelectedItem is TimeSlot selectedSlot)
            
                lblAvailablePositions.Text =
                    $"Available positions: " +
                    $"{selectedSlot.AvailablePositions}";
            UpdateAppointmentSummary();
        }
        private void cboService_SelectedIndexChanged(object sender,
            EventArgs e)
        {
            UpdateAppointmentSummary();
        }
        private void btnConfirmBooking_Click(
            object sender, EventArgs e)
        {
            if (currentBeneficiary == null)
            {
                MessageBox.Show(
                    "No beneficiary is currently logged in.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboServiceCentre.SelectedItem
                is not ServiceCentre selectedCentre)
            {
                MessageBox.Show(
                    "Please select a service centre.",
                    "Missing Centre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboService.SelectedItem
                is not Service selectedService)
            {
                MessageBox.Show(
                    "Please select a SASSA service.",
                    "Missing Service",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboTimeSlot.SelectedItem
                is not TimeSlot selectedSlot)
            {
                MessageBox.Show(
                    "Please select an available time slot.",
                    "Missing Time Slot",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool duplicateBooking = SystemData.Bookings.Any(
                booking =>
                    booking.Beneficiary.UserID ==
                        currentBeneficiary.UserID &&
                    booking.TimeSlot.AppointmentDateTime ==
                        selectedSlot.AppointmentDateTime &&
                    booking.Status != BookingStatus.Cancelled);

            if (duplicateBooking)
            {
                MessageBox.Show(
                    "You already have a booking for this date and time.",
                    "Duplicate Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Booking newBooking = new Booking
            {
                Beneficiary = currentBeneficiary,
                Service = selectedService,
                ServiceCentre = selectedCentre
            };

            if (!newBooking.CreateBooking(selectedSlot))
            {
                MessageBox.Show(
                    "The selected time slot is no longer available.",
                    "Booking Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                RefreshAvailableSlots();
                return;
            }

            SystemData.Bookings.Add(newBooking);
            using (BookingConfirmationForm confirmationForm = new BookingConfirmationForm(newBooking))
            {
                DialogResult result = confirmationForm.ShowDialog(this);
                   if(result == DialogResult.Retry)
                {
                    btnClear_Click(btnClear, EventArgs.Empty);
                    return;
                }
                //RefreshAvailableSlots();
            }
            Close();
        }
        private void SetUpAppointmentSummary()
        {
            dgvAppointmentSummary.Columns.Clear();
            dgvAppointmentSummary.AutoGenerateColumns = false;
            dgvAppointmentSummary.AllowUserToAddRows = false;
            dgvAppointmentSummary.ReadOnly = true;
            dgvAppointmentSummary.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAppointmentSummary.Columns.Add("Service", "Service");
            dgvAppointmentSummary.Columns.Add("Centre", "Service Centre");
            dgvAppointmentSummary.Columns.Add("Date", "Date");
            dgvAppointmentSummary.Columns.Add("Time", "Time");
        }

        private void UpdateAppointmentSummary()
        {
            dgvAppointmentSummary.Rows.Clear();

            if (cboService.SelectedItem is not Service service ||
                cboServiceCentre.SelectedItem is not ServiceCentre centre ||
                cboTimeSlot.SelectedItem is not TimeSlot slot)
                return;

            dgvAppointmentSummary.Rows.Add(
                service.ServiceName,
                centre.CentreName,
                dtpBookingDate.Value.ToString("dd MMMM yyyy"),
                slot.Date.Add(slot.Time).ToString("HH:mm"));
        }

        public string NextPage { get; private set; } = "";
        public void GoToPage(string page)
        {
            NextPage = page;
            Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            // already on new booking
        }
        private void btnMyBooking_Click(object sender, EventArgs e)
        {
            GoToPage("MyBookings");
        }
        private void btnQueueStatus_Click(object sender, EventArgs e)
        {
            GoToPage("QueueStatus");
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            GoToPage("Profile");
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GoToPage("Logout");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            cboServiceCentre.SelectedIndex = 0;
            cboService.SelectedIndex = 0;
            dtpBookingDate.Value = DateTime.Today.AddDays(1);
            RefreshAvailableSlots();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBookingForm_Load(object sender, EventArgs e)
        {
            SetUpAppointmentSummary();
            dtpBookingDate.MinDate = DateTime.Today.AddDays(1);
            dtpBookingDate.Value = DateTime.Today.AddDays(1);
            cboServiceCentre.DisplayMember = "CentreName";
            cboServiceCentre.ValueMember = "CentreID";
            cboServiceCentre.DataSource = SystemData.ServiceCentres
                .Where(centre => centre.IsActive)
                .ToList();

            cboService.DisplayMember = "ServiceName";
            cboService.ValueMember = "ServiceID";
            cboService.DataSource = SystemData.Services
                .Where(service => service.IsActive)
                .ToList();
            
            RefreshAvailableSlots();
            UpdateAppointmentSummary();
        }
        private void RefreshAvailableSlots()
        {
            if (cboServiceCentre.SelectedItem is not ServiceCentre selectedCentre)
            {
                cboTimeSlot.DataSource = null;
                lblAvailablePositions.Text = "No centre selected";
                return;
            }
            var availableSlots = SystemData.TimeSlots
                .Where(slot =>
                slot.CentreID == selectedCentre.CentreID &&
                slot.Date.Date == dtpBookingDate.Value.Date &&
                slot.CheckAvailability())
                .ToList();

            cboTimeSlot.DataSource = null;
            cboTimeSlot.DataSource = availableSlots;

            if (availableSlots.Count == 0)
                lblAvailablePositions.Text = "No available slots for this date";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}




