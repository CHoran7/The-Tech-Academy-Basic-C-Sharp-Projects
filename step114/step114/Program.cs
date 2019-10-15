using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step114
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Class1.Method1(12);
            Console.WriteLine(value);
            decimal pi = 3.14159m;
            int rounded = Class1.Method1(pi);
            Console.WriteLine(rounded);
            int fiveBigger = Class1.Method1("4");
            Console.WriteLine(fiveBigger);
            Console.ReadLine();
        }
    }
}
