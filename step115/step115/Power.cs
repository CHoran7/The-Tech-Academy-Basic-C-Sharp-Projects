using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step115
{
    class Power
    {
        public static int Exponent(int mathBase, int exponent = 2)
        {
            double temp1 = Convert.ToDouble(mathBase);
            double temp2 = Convert.ToDouble(exponent);

            int result = Convert.ToInt32(Math.Pow(temp1, temp2));
            return result;
        }
    }
}
