using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do operations on?");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int dub = MathMethods.Doubling(userNum);
            Console.WriteLine("Double your number is: " + dub);
            int trip = MathMethods.Triple(userNum);
            Console.WriteLine("Triple your number is: " + trip);
            int square = MathMethods.Square(userNum);
            Console.WriteLine("The square of your number is: " + square);
            Console.ReadLine();
        }
    }
}
