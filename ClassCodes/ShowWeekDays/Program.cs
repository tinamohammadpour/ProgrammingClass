using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowWeekDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DayCounter;
            Console.WriteLine("Choose a Number from 1 to 7 So We Can Show You Week Days");
            Console.WriteLine("Enter \"0\" if You want To Exit");
            while (true)
            {
                DayCounter = Console.ReadLine();
                if (DayCounter == "1")
                    Console.WriteLine("SaturDay");
                else if (DayCounter == "2")
                    Console.WriteLine("SunDay");
                else if (DayCounter == "3")
                    Console.WriteLine("MonDay");
                else if (DayCounter == "4")
                    Console.WriteLine("TuesDay");
                else if (DayCounter == "5")
                    Console.WriteLine("WednesDay");
                else if (DayCounter == "6")
                    Console.WriteLine("ThursDay");
                else if (DayCounter == "7")
                    Console.WriteLine("FriDay");
                else if (DayCounter == "0")
                {
                    Console.WriteLine("Bye User");
                    break;
                }
                else
                    Console.WriteLine("the Input Is Not Valid");
            }
        }
    }
}
