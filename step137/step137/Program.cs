using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.14159m;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
