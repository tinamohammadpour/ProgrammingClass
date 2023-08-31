using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetermineSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number so we can tell you its Sign");
            int Entered = Convert.ToInt32(Console.ReadLine());
            if (Entered >= 0)
                Console.WriteLine($"{Entered} Is Positive (+)");
            else
                Console.WriteLine($"{Entered} Is Negetive (-)");

        }
    }
}
