using System;

namespace assignment_1_Login_system
{
    class Program
    {
        static void Main(string[] args)
        {
            User bob = new User("Bobby", "bob123","Bob smith");
            Console.WriteLine("user looged in: " + bob.loggedin);
            Console.WriteLine(bob.checkLogin("ankit", "ankit123"));
            Console.WriteLine(bob.checkLogin("Bobby","bob123"));
            Console.WriteLine("user looged in: " + bob.loggedin);

            Console.WriteLine(bob.realname);

            bob.changepassword("bob2258");
            bob.logout();
            Console.WriteLine(bob.checkLogin("Bobby","bob2258"));
        }
    }
    
}
