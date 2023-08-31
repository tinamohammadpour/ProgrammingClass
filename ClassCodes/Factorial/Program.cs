using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Factorial(int num)
            {
                long Fact = 1;
                for (int i = 1; i <= num; i++)
                    Fact = Fact * i;
                return Fact;
            }

            Console.WriteLine("Enter your Number So i Compute Its Factorial");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(Number));
        }
    }
}
