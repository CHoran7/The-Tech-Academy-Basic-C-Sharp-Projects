using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main()
        {
            string fName = "Cole";
            string mName = "Howard";
            string lName = "Horan";
            Console.WriteLine(fName + " " + mName + " " + lName);
            string abbreviation = "ip";
            abbreviation = abbreviation.ToUpper();
            Console.WriteLine(abbreviation);
            StringBuilder sb = new StringBuilder();
            sb = sb.Append("StringBuilder is very useful. ");
            sb = sb.Append("It allows you to make dynamic strings. ");
            sb = sb.Append("This is useful because strings are immutable, or not able to be changed. ");
            sb = sb.Append("When you assign a new value to a string C# really just creates a new string which can slow down programs.");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
