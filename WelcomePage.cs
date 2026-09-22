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

        private void btnStaffLogin_Click(
            object sender, EventArgs e)
        {
            //OpenLoginForm(UserRole.Staff);
            Login loginForm = new Login(UserRole.Staff);
            loginForm.ShowDialog();

        }

        private void btnBeneficiaryLogin_Click(
            object sender, EventArgs e)
        {
            //OpenLoginForm(UserRole.Beneficiary);
            Login loginForm = new Login(UserRole.Beneficiary);
            loginForm.ShowDialog();
        }

        private void btnAdminLogin_Click(
            object sender, EventArgs e)
        {
            //OpenLoginForm(UserRole.Administrator);
            Login loginForm = new Login(UserRole.Administrator);
            loginForm.ShowDialog();
        }
    
    }
}
