using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class Beneficiary : User
    {
        public string ContactNumber { get; set; }   
        public override UserRole Role
        {
            get
            {
                return UserRole.Beneficiary;
            }
        }
    }
}
