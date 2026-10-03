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
    public partial class BookingConfirmationForm : Form
    {
        private Booking? confirmedBooking;
        private Beneficiary? currentBeneficiary;
        private Action<Form> navigate;
        public BookingConfirmationForm()
        {
            InitializeComponent();
        }
        public BookingConfirmationForm(
        Booking booking,
        Beneficiary beneficiary,
        Action<Form> navigate) : this()
        {
            confirmedBooking = booking;
            currentBeneficiary = beneficiary;
            this.navigate = navigate;

            //LoadBookingDetails();
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
                    "No booking was supplied.");

               // Close();
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
            //DialogResult = DialogResult.Retry;
            //Close();
            if (currentBeneficiary == null || navigate == null)
                return;
            navigate(new NewBookingForm(currentBeneficiary, navigate));
        }

        private void btnDone_Click(
            object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
            //Close();
            if (currentBeneficiary == null || navigate == null)
                return;

            navigate(new frmMyBookings(currentBeneficiary));

        }


    }
}

    
