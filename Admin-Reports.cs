using SASSAQueueManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zanele_Admin_BookingManagement
{
    public partial class Admin_Reports : Form
    {
        private Administrator? currentAdministrator;
        public Admin_Reports()
        {
            InitializeComponent();
        }
        public Admin_Reports(Administrator administrator) : this()
        {
            currentAdministrator = administrator
                ?? throw new ArgumentNullException(nameof(administrator));
        }

        
    }
}
