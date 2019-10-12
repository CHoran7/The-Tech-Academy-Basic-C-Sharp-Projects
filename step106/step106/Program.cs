using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>() { 1,4,9,16,25,36 };
                Console.WriteLine("Please select a number.");
                int number1 = Convert.ToInt32(Console.ReadLine());
            
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(numbers[i] / number1);
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            Console.ReadLine();
        }
    }
}
