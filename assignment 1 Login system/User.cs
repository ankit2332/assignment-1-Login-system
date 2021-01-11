using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_1_Login_system
{
    class User
    {
        private string username;
        private string password;
        public string realname;
        public bool loggedin = false;

        public User(string un, string pw, string rn) // Constructor
        {
            username = un;
            password = pw;
            realname = rn;
        }

        public bool checkLogin(string un, string pw) // function
        {
            if (un == username && pw == password)
            {
                loggedin = true;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void logout()
        {
            loggedin = false;
        }
        
        public void changepassword(string newpassword)
        {
            if (loggedin == true)
            {
                Console.WriteLine("YOU HAVE CHANGED YOUR PASSWORD");
                password = newpassword;
            }
            else
            {
                Console.WriteLine("YOU ARE NOT LOGGED IN. CANNOT CHANGE YOUR PASSWORD!");
            }
                
        }
        
    }
}
