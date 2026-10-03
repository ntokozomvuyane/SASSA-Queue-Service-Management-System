using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SASSAQueueManagementSystem
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void OpenLoginForm(UserRole selectedRole)
        {
            using (Login loginForm =
                   new Login(selectedRole))
            {
                this.Hide();
                loginForm.ShowDialog();
                this.Show();
            }
        }
        private void OpenSharedLogin()
        {
            Hide();

            using (var loginForm = new Login())
            {
                loginForm.ShowDialog(this);
            }

            Show();
        }

        private void btnStaffLogin_Click(
            object sender, EventArgs e)
        {

            //Hide();

            //using (var staffLogin= new StaffLogin())
            //{
            //    staffLogin.ShowDialog(this);
            //}

            //Show();
            OpenSharedLogin();

        }

        private void btnBeneficiaryLogin_Click(
            object sender, EventArgs e)
        {
            ////OpenLoginForm(UserRole.Beneficiary);
            //Login loginForm = new Login(UserRole.Beneficiary);
            //loginForm.ShowDialog();
            OpenSharedLogin();
        }

        private void btnAdminLogin_Click(
            object sender, EventArgs e)
        {
            //OpenLoginForm(UserRole.Administrator);
            //Login loginForm = new Login(UserRole.Administrator);
            //loginForm.ShowDialog();
            OpenSharedLogin();
        }
      

    }
}
