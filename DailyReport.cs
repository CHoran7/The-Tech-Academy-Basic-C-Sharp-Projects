using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDateTypes
{
    class DailyReport
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? please answer \"true\" or \"false\"");
            string Help = Console.ReadLine();
            bool help = Convert.ToBoolean(Help);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            int hours = Convert.ToInt32(Hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
