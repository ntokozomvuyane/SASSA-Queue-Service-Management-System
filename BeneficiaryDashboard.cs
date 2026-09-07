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
        public BeneficiaryDashboard()
        {
            InitializeComponent();
        }

        private void btnbookingnewappointment_Click(object sender, EventArgs e)
        {
            NewBookingForm newBooking = new NewBookingForm();
            newBooking.Show();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            NewBookingForm newBooking = new NewBookingForm();
            newBooking.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout_form logout_Form = new Logout_form();
            logout_Form.Show();
        }
    }
}
