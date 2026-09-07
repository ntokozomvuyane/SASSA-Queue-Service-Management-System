using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sassa_Queue_And_Service_Management_System
{
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(id))
            {
                errorProvider1.SetError(txtUsername,"Your Beneficiary ID number is required");
                return;
            }
            else
            {
                if(id.Length != 13)
                {
                    MessageBox.Show("South African ID contains exactly 13 characters");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(txtPassword, "The password is required");
                return;
            }

            users = DataManager.LoadUsers();  //take data loaded by DataManager and put it into "users" list

            //ENSURE THAT THE LOGGED-IN USER EXIST IN THE "users" list.

            User loggedInUser = null;    // assume at first no one is logged in.
            foreach (User user in users)    
            {
                if (user.GetIDNumber() == id && user.GetPassword() == password)
                {
                    loggedInUser = user;   //the person loggedin is found in the list of users
                    break;                 // when found, no need to continue searching, thus you break!!
                }
                
            }
            if (loggedInUser != null)
            {
                MessageBox.Show($" Welcome {loggedInUser.GetName()}! You have successfully logged in to our system");
                return;
            }
            else
            {
                MessageBox.Show("Invalid ID number or password");
                return;
            }
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
           users = DataManager.LoadUsers();  //take a list that datamanager loaded and put it into "users" list
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();  
            registration.ShowDialog();     
            users = DataManager.LoadUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
    }
}
