using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("+:Sum,-:Minus,/:Divide,*:Multiply");
            string Option =Console.ReadLine();

            if (Option == "+")
                    Console.WriteLine(num1 + num2);
            else if (Option == "-")
                    Console.WriteLine(num1 - num2);
            else if (Option == "/" && num2 != 0)
                    Console.WriteLine(num1 / num2);
            else if (Option == "*")
                    Console.WriteLine(num1 * num2);
            
            else
                Console.WriteLine("The Input Option is Not Valid");

        }
    }
}
