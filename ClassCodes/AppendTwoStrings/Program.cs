using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppendTwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 String So I Append them");
            string String1 = Console.ReadLine();
            string String2 = Console.ReadLine();
            Console.WriteLine((String1 + String2).ToUpper());
        }
    }
}
