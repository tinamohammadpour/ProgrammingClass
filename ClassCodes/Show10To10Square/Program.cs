using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show10To10Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is A 10*10 Multiplication Table");
            int Col;
            int CountRow = 0;
            for (int Row = 1; Row <= 10; Row++)
            {
                Col = Row;
                while (CountRow != 10)
                {
                    Console.Write(Col + " ");
                    Col++;
                    CountRow++;
                    if (Col > 10)
                        Col = 1;
                }
                CountRow = 0;
                Console.WriteLine();
            }

        }
    }
}
