using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is The Program To Show you the first 10000 Fibo Numbers ");
            Thread.Sleep(1000);
            long[] Fibos = new long[100];
            Fibos[0] = 0;
            Fibos[1] = 1;
            for (int Index = 2; Index < 100; Index++)
                Fibos[Index] = Fibos[Index - 1] + Fibos[Index - 2];
            foreach (var Fibo in Fibos)
                Console.WriteLine(Fibo);

        }
    }
}
