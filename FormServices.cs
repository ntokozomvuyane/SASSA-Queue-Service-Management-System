using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class frmServices : Form
    {
        private Administrator? currentAdministrator;
        public frmServices()
        {
            InitializeComponent();
        }

        public frmServices(Administrator administrator) : this() 
        { 
            currentAdministrator = administrator
                ?? throw new ArgumentNullException(nameof(administrator));
        }
    }
}
