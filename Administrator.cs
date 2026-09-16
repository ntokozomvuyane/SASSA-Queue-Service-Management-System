using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class Administrator : User
    {
        public string EmployeeNumber { get; set; }
        public override UserRole Role
        {
            get
            {
                return UserRole.Administrator;
            }
        }   
    }
}
