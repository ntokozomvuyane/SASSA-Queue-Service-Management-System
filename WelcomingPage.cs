using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class WelcomingPage : Form
    {
        public WelcomingPage()
        {
            InitializeComponent();
        }

        private void btnLoginMyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Show();
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegistrationForm registration = new frmRegistrationForm();
            registration.Show();

            this.Show();
        }
    }
}
