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
    public partial class Logout_form : Form
    {
        public Logout_form()
        {
            InitializeComponent();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            NewBookingForm newBooking = new NewBookingForm();
            newBooking.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BeneficiaryDashboard beneficiaryDashboard = new BeneficiaryDashboard();
            beneficiaryDashboard.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
