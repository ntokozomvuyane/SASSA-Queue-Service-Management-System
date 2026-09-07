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
    public partial class frmBeneficiary_welcomePage : Form
    {

        public frmBeneficiary_welcomePage()
        {
            InitializeComponent();
        }
        //List<User> users = new List<User>();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();                        // hides the WELCOME page

            LoginForm login = new LoginForm();  // creates new login form
            login.ShowDialog();                       //displays the Loginform
            this.Show();                           //Login page appeares again when the login screen is closed

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();  //the form we are working on ,giving it a variable "registration" after creating a new object
            registration.ShowDialog();                              // basically ask to show the RegistrationForm on the screen

            this.Show();                                  //when the registration form is closed, the welcome page will show again

        }
    }
}
