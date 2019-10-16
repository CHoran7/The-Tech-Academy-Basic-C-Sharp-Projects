using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step117
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            int a = 5;
            Console.WriteLine("Please write a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Class1.Divide(userNum);
            Class1.DivideTil2(userNum, out a);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
