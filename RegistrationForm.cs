using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //private void lblNewBeneficiatyCreate_Click(object sender, EventArgs e)
        //{
        //    frmRegistrationForm frmRegistrationForm = new frmRegistrationForm();
        //    frmRegistrationForm.Show();
        //    this.Hide();
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
