using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        PrintBetween(num1, num2);
    }

    private static void PrintBetween(int num1, int num2)
    {
        if (num1 <= num2)
        {
            for (int i = num1; i <= num2; i++)
                Console.WriteLine(i);
        }
        else
        {
            for (int i = num2; i <= num1; i++)
                Console.WriteLine(i);
        }
    }
}