using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public abstract class User
    {
        public string UserID { get; set; }  
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract UserRole Role { get; }  

        public bool ValidateLogin(string username, string password)
        {
            return Username.Equals(username, StringComparison.OrdinalIgnoreCase) && Password == password;
        }   
    }
}
