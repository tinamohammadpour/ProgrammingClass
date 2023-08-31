using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Show Odd numbers from 100 t0 999");
            for (int i = 101; i <= 999; i += 2)
                Console.WriteLine(i);

        }
    }
}
