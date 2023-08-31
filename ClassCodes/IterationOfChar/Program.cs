using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationOfChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Text");
            string Text = Console.ReadLine();
            Console.WriteLine("Enter The Charecter You Are Looking For");
            char InputChar = Convert.ToChar(Console.ReadLine());
            int CharCounter = 0;
            for (int i = 0; i <= Text.Length - 1; i++)
            {
                if (Text[i] == Char.ToUpper(InputChar) || Text[i] == Char.ToLower(InputChar))
                    CharCounter++;
            }
            Console.WriteLine($"The Number of {InputChar} in the Text Is:{CharCounter}");

        }
    }
}
