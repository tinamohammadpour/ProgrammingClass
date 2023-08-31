using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Array.Sort(new int[] { num1, num2, num3 });
            Console.WriteLine($"{(new int[] { num1, num2, num3 })[0]} Is Our Minimum Number");
            Console.WriteLine($"{(new int[] { num1, num2, num3 })[2]} Is Our Maximum Number");
            Console.WriteLine($"{((new int[] { num1, num2, num3 })[0] + (new int[] { num1, num2, num3 })[1] + (new int[] { num1, num2, num3 })[2]) / 3} Is The Average");

        }
    }
}
