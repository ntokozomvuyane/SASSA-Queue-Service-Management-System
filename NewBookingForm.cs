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
        public NewBookingForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BeneficiaryDashboard beneficiaryDashboard = new BeneficiaryDashboard();
            beneficiaryDashboard.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout_form logout_Form = new Logout_form();
            logout_Form.Show();
        }

        private void btnConfirmbooking_Click(object sender, EventArgs e)
        {
            if (cmbSelectService.SelectedIndex == -1 || cmbServiceCentre.SelectedIndex == -1 || cmbTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Service Centre, Service and Time.", "Incomplete Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedService = cmbSelectService.Text;
            string seviceCentre = cmbServiceCentre.Text;
            string selectedDate = dtpDate.Value.ToString("dd/MM/yyyy");
            string selectedTime = cmbTime.Text;

            dgvSummary.Rows.Add(selectedService, seviceCentre, selectedDate, selectedTime);

            MessageBox.Show("Your booking has been confirmed succcessfully!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbSelectService.SelectedIndex = -1;
            cmbServiceCentre.SelectedIndex = -1;
            cmbTime.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
        }
    }
}
