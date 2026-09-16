using System;
using System.Collections.Generic;
using System.Text;

namespace SASSAQueueManagementSystem
{
    public class UserRepository
    {
        public static List<User> User { get; } = new List<User>
        {
            new Beneficiary
            {
                UserID = "B001",
                FullName = "John Doe",
                Username = "johndoe",
                Password = "1234",
                ContactNumber = "0712345678"
            },
            new StaffMember
            {
                UserID = "S001",
                FullName = "Jane Smith",
                Username = "janesmith",
                Password = "5678",
                StaffID = "STAFF001",
                ServiceCentre = "Johannesburg"
            },
            new Administrator
            {
                UserID = "A001",
                FullName = "Officer Bhengu",
                Username = "officerb",
                Password = "1234",
                EmployeeNumber = "EMP001"   
            }
        };
    }
}
