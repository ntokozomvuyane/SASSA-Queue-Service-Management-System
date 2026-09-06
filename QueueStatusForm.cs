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
        public QueueStatusForm()
        {
            InitializeComponent();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            frmMyBookings myBookings = new frmMyBookings();
            myBookings.Show();
            this.Hide();
        }
    }
}
