using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string DefaultUserName = "User";
            const string DefaultPassword = "Pass";
            Console.WriteLine("Enter your UserName");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Your Pawssword");
            string Password = Console.ReadLine();
            UserName.Trim();
            Password.Trim();
            if (UserName.Equals(DefaultUserName) && Password.Equals(DefaultPassword))
            {
                Console.WriteLine("Login Successfull");
            }
            else
                Console.WriteLine("Login Failed");
        }
    }
}
