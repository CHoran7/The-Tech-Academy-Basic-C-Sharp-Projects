using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to provide a second number? y/n");
            string check = Console.ReadLine();
            if(check == "y")
            {
                Console.WriteLine("What number?");
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                int result = Power.Exponent(userNum1, userNum2);
                Console.WriteLine("{0} to the power of {1} is {2}", userNum1, userNum2, result);
            }
            else
            {
                int result = Power.Exponent(userNum1);
                Console.WriteLine("{0} to the power of 2 is {1}", userNum1, result);
            }
            Console.ReadLine();
        }
    }
}
