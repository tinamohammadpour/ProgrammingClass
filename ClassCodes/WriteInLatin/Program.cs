using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteInLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input Number from 1 to 9 So i write it in Latin");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("One");
                    break;
                case "2":
                    Console.WriteLine("Two");
                    break;
                case "3":
                    Console.WriteLine("Three");
                    break;
                case "4":
                    Console.WriteLine("Four");
                    break;
                case "5":
                    Console.WriteLine("Five");
                    break;
                case "6":
                    Console.WriteLine("Six");
                    break;
                case "7":
                    Console.WriteLine("Seven");
                    break;
                case "8":
                    Console.WriteLine("Eight");
                    break;
                case "9":
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("The Input Is Not Valid");
                    break;
            }
        }
    }
}
