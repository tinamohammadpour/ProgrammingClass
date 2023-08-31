using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharBetweenStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your Input string");
            string InputWord = Console.ReadLine();
            Console.WriteLine("write your Input Charecter you want to type between the chars of your string");
            char InputChar = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i <= InputWord.Length - 1; i++)
                Console.Write($"{InputWord[i]} {InputChar}");
        }
    }
}
