using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please provide a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime future = new DateTime();
            future = DateTime.Now.AddHours(userNum);
            Console.WriteLine("In {0} hours it will be {1}.", userNum, future);
            Console.Read();
        }
    }
}
