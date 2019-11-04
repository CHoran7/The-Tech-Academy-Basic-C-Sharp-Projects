using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step165
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("What is your age?");
                int yearBorn = 2019 - Convert.ToInt32(Console.ReadLine());
                if (yearBorn == 2019)
                {
                    throw new ZeroAgeException();
                }
                if (yearBorn > 2019)
                {
                    throw new NegativeAgeException();
                }
                Console.WriteLine("You were born in {0}", yearBorn);
            }
            catch (ZeroAgeException)
            {
                Console.WriteLine("Please provide a non-zero answer.");
            }
            catch (NegativeAgeException)
            {
                Console.WriteLine("Please provide a positive answer.");

            }
            catch (Exception)
            {
                Console.WriteLine("Please provide a non-zero, postive integer.");
            }
            Console.ReadLine();
        }
    }
}
