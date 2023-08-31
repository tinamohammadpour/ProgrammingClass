using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeBenefit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double CountProfit(int Rial, double Profit, int Month)
            {
                double Result = Math.Pow((100 + Profit) / 100, Month) * Rial;
                return Result;
            }
            Console.WriteLine("Enter the Money Amount");
            int rial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the profit percent");
            double profit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountProfit(rial, profit, month));
        }
    }
}
