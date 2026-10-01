using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class BookingConfirmationForm : Form
    {
        private Booking? confirmedBooking;

        public BookingConfirmationForm()
        {
            InitializeComponent();
        }
        public BookingConfirmationForm(Booking booking) : this()
        {
            confirmedBooking = booking;
        }

        private void BookingConfirmationForm_Load(
            object sender, EventArgs e)
        {
            if (confirmedBooking == null)
            {
                MessageBox.Show(
                    "No booking was supplied.",
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
                return;
            }

            lblReferenceNumber.Text =
                confirmedBooking.ReferenceNumber;

            lblServiceName.Text =
                confirmedBooking.Service.ServiceName;

            lblCentreName.Text =
                confirmedBooking.ServiceCentre.CentreName;

            lblAppointmentDate.Text =
                confirmedBooking.TimeSlot
                    .AppointmentDateTime
                    .ToString("dd MMMM yyyy");

            lblAppointmentTime.Text =
                confirmedBooking.TimeSlot
                    .AppointmentDateTime
                    .ToString("HH:mm");

            lblBookingStatus.Text =
                confirmedBooking.Status.ToString();
        }

        private void btnCreateAnother_Click(
            object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnDone_Click(
            object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}

    
