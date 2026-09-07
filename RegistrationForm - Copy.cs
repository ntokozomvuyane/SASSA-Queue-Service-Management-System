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
    public partial class RegistrationForm : Form
    {
        private List<User> users = new List<User>();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {




            //getting user input
            string name = txtFullName.Text;
            string beneficiary_id = txtBeneficiaryID.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            //validate user input
            if (txtFullName.Text == "" || txtBeneficiaryID.Text == "" || txtEmail.Text =="" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please complete all fields in order to register");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

           

            // creating a new User OBJECT
            User newUser = new User();

            newUser.SetDetails(name, beneficiary_id, email, password);

            DataManager.SaveUser(newUser);  //"Datamanager, please save the newuser's information in the text file(userFile)"


            MessageBox.Show("Your account was successfully created! ");
            //this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();  // closes the registration form and returns to the previous form (welcome page)
        }
    }

}
