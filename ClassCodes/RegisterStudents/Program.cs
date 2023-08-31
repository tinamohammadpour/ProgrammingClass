using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter the Name of The Student");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the LastName of The Student");
                String lastName = Console.ReadLine();
                Console.WriteLine("Enter the Id of The Student");
                string id = Console.ReadLine();
                Console.WriteLine($"Name:{name},LastName:{lastName},ID:{id}");
            }

        }
    }
}
