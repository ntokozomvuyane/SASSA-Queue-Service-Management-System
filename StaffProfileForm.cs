using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class frmStaffProfile : Form
    {
        private StaffMember? currentStaff;
        public frmStaffProfile()
        {
            InitializeComponent();
        }
        public frmStaffProfile(StaffMember staffMember) : this()
        {
            currentStaff = staffMember
                ?? throw new ArgumentNullException(nameof(staffMember));

            // Optional controls if they exist on the form:
            lblStaffName.Text = currentStaff.FullName;
             lblStaffID.Text = currentStaff.StaffID;
             lblServiceCentre.Text = currentStaff.ServiceCentre;
        
    }

}
}
