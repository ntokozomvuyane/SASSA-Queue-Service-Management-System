using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class StaffMember : User
    {
        public string StaffID { get; set; } 
        public string ServiceCentre { get; set; }   

        public override UserRole Role 
        {
           get
            {
                return UserRole.Staff;
            }
        }   
    }
}
