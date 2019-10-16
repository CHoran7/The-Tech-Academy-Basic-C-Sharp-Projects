using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step117
{
    class Class1
    {
        public static void Divide(int quo)
        {
            int result = quo / 2;
            Console.WriteLine(result);
        }

        public static double Divide(double quo)
        {
            double result = quo / 3;
            return result;
        }

        public static void DivideTil2(int quo, out int count)
        {
            count = 0;
            while(quo != 1)
            {
                quo = quo / 2;
                count++;
            }
            Console.WriteLine(quo);
        }
    }
}
