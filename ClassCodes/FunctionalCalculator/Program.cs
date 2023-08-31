using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the Input Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+,-,*,%,/");
            Console.WriteLine("Enter the Sing of the Action you want");
            string Option = Console.ReadLine();
            if (Option == "+")
                Console.WriteLine(Sum(num1, num2));
            else if (Option == "-")
                Console.WriteLine(Minus(num1, num2));
            else if (Option == "*")
                Console.WriteLine(Multiply(num1, num2));
            else if (Option == "%")
                Console.WriteLine(Reminder(num1, num2));
            else if (Option == "/")
                Console.WriteLine(Divide(num1, num2));
            else
                Console.WriteLine("Your Input Is Not Valid");
        }

        private static int Reminder(int num1, int num2) => num1 % num2;

        private static double Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else return 0;
        }

        private static int Minus(int num1, int num2) => num1 - num2;

        private static int Multiply(int num1, int num2) => num1 * num2;

        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
