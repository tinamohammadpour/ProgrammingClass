using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Number and I will Show You the Sum if Its Digits");
            String InputNumber = Console.ReadLine();
            if (Char.IsDigit(InputNumber, 0) == false)
                Console.WriteLine("The Input Is Not Valid");
            else
            {
                int SumOfDigits = 0;
                Char[] Digits = InputNumber.ToCharArray();
                foreach (var digit in Digits)
                {
                    SumOfDigits += Convert.ToInt32(new string(digit, 1));
                }
                Console.WriteLine(SumOfDigits);
            }

        }
    }
}
