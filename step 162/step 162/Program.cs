using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Cole Horan";
            var stuff = " is currently studying.";
            Console.WriteLine(myName + stuff);
            twoConstructors race = new twoConstructors("19:52", 5);
            twoConstructors race2 = new twoConstructors("17:19");
        }
    }
}
