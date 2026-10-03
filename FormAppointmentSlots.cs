using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class frmAppointmentSlots : Form
    {
        private Administrator? currentAdministrator;
        public frmAppointmentSlots()
        {
            InitializeComponent();
        }
        public frmAppointmentSlots(Administrator administrator) : this()
        {
            currentAdministrator = administrator
                ?? throw new ArgumentNullException(nameof(administrator));
        }
    }
}
