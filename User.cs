using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sassa_Queue_And_Service_Management_System
{
    public class User
    {
        private string Name;
        private string idNumber;
        private string Email;
        private string Password;
        // SET all the details at once
        public void SetDetails(string _name, string id_number, string _email, string _password)
        {
            this.Name = _name;
            this.idNumber = id_number;
            this.Email = _email;
            this.Password = _password;

        }
        
        //GET all the details at once
        public string GetDetails()
        {
            return Name + "," + idNumber + "," + Email + "," + Password;
            
        }

        //GET details individually
        public string GetName()
        {
            return Name;
        }
        public string GetIDNumber()
        {
            return idNumber;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetPassword()
        {
            return Password;
        }

    }
}



