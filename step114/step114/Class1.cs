using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step114
{
    class Class1
    {
        public static int Method1(int integer)
        {
            int bigger = integer * 100;
            return bigger;
        }

        public static int Method1(decimal dec)
        {
            int rounded = Convert.ToInt32(dec);
            return rounded;
        }

        public static int Method1(string number)
        {
            int calc = Convert.ToInt32(number);
            calc = calc + 5;
            return calc;
        }
    }
}
