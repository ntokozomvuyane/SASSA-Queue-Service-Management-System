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

namespace Zanele_Admin
{
    public partial class frmBookings : Form
    {
        private Administrator? currentAdministrator;
        public frmBookings()
        {
            InitializeComponent();
        }
        public frmBookings(Administrator administrator) : this()
        {
            currentAdministrator = administrator
                ?? throw new ArgumentNullException(nameof(administrator));
        }

    }
}
