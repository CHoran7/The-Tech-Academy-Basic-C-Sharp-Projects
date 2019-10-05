using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step92
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimension = width + length + height;
                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    double quote = dimension * weight / 100.00;
                    Console.WriteLine("It will be $" + quote + " to ship. Thank you.");
                    Console.ReadLine();
                }
            }
        }
    }
}
