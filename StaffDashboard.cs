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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard(string staffName, string staffRole)
        {
            InitializeComponent();

            lblStaffName.Text = staffName;
            lblStaffRole.Text = staffRole;

            lblDate.Text = "Johannesburg CBD - " + DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
