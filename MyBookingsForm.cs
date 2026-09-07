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
        public frmMyBookings()
        {
            InitializeComponent();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            Booking upcomingBooking = new Booking();

            upcomingBooking.SetBookingID("SASSA-2026-00482");
            upcomingBooking.SetService("New Grant Application");
            upcomingBooking.SetCentre("Johannesburg Central SASSA Centre");
            upcomingBooking.SetDate("10 September 2026");
            upcomingBooking.SetTime("09:30-10:00");
            upcomingBooking.SetStatus("Confirmed");

            MessageBox.Show($"Booking ID: {upcomingBooking.GetBookingID()} \n" 
                + $"Service: {upcomingBooking.GetService()} \n"
                + $"Centre: {upcomingBooking.GetCentre()} \n" 
                + $"Date: {upcomingBooking.GetDate()} \n"
                + $"Time: {upcomingBooking.GetTime()} \n" 
                + $"Status: {upcomingBooking.GetStatus()}", "Booking Details");
        }
    }
}
