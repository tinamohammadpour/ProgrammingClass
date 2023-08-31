using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Input Day So i Compute The Month");
            int InputDay = Convert.ToInt32(Console.ReadLine());
            if (InputDay < 1 || InputDay > 365)
                Console.WriteLine("the Input Day Is Not Valid");
            else
            {
                if (InputDay >= 1 && InputDay <= 31)
                    Console.WriteLine("Farvardin");

                if (InputDay >= 32 && InputDay <= 62)
                    Console.WriteLine("Ordibehesht");
                if (InputDay >= 63 && InputDay <= 93)
                    Console.WriteLine("Khordad");
                if (InputDay >= 94 && InputDay <= 124)
                    Console.WriteLine("Tir");
                if (InputDay >= 125 && InputDay <= 155)
                    Console.WriteLine("Mordad");
                if (InputDay >= 156 && InputDay <= 186)
                    Console.WriteLine("Shahrivar");
                if (InputDay >= 187 && InputDay <= 216)
                    Console.WriteLine("Mehr");
                if (InputDay >= 217 && InputDay <= 246)
                    Console.WriteLine("Aban");
                if (InputDay >= 247 && InputDay <= 276)
                    Console.WriteLine("Azar");
                if (InputDay >= 277 && InputDay <= 306)
                    Console.WriteLine("Dey");
                if (InputDay >= 307 && InputDay <= 336)
                    Console.WriteLine("Bahman");
                if (InputDay >= 337 && InputDay <= 365)
                    Console.WriteLine("Esfand");
            }
        }
    }
}
