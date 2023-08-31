using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensBetweenTwoNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void ShowEvens(int num1, int num2)
            {
                if (num1 > num2)
                {
                    for (int i = num2 + 1; i < num1; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    }
                }
                if (num1 < num2)
                {
                    for (int j = num1 + 1; j < num2; j++)
                    {
                        if (j % 2 == 0)
                            Console.WriteLine(j);
                    }
                }
            }
            Console.WriteLine("Enter the First Number");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            ShowEvens(Num1, Num2);
        }
    }
}
