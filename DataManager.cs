using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sassa_Queue_And_Service_Management_System
{
    public static class DataManager
    {
         static string UsersFile = "users.txt";


        public static void SaveUser(User user)  // client represent one new object created from the class
        {
            string line = user.GetDetails();   // save information as new line in the text file
                                                // name, idnumber, email, password  - line

            File.AppendAllText(UsersFile,line + Environment.NewLine);
        }

        public static List<User> LoadUsers()  // it LOADS users from the users.txt file into
                                              //
                                              // a list of User objects
        {
            List<User> users = new List<User>();

            if (File.Exists(UsersFile))
            {
                string[] lines = File.ReadAllLines(UsersFile);  // create an array of strings called lines, it reads everyline on a new user

                foreach (string line in lines)         //name,id, email, password
                {
                    string[] parts = line.Split(',');   // group each that are the same into index  e.g[0] names, [1]emails

                    if (parts.Length ==4)
                    {
                        User client1 = new User();

                        client1.SetDetails(parts[0], parts[1], parts[2], parts[3]);

                        users.Add(client1);

                    }

                }
            }

            return users;
        }
    }
}
