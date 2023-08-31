using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the Lines you Want to print Star in");
            int LineCounter = Convert.ToInt32(Console.ReadLine());
            PrintStar(LineCounter);
        }

        private static void PrintStar(int LineCounter)
        {
            for (int i = 0; i <= LineCounter; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
