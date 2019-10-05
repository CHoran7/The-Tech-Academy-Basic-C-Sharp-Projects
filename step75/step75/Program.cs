using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step75
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool duiTicket = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTickets = Convert.ToInt32(Console.ReadLine());
            bool oldEnough = age > 15;
            bool ticketNum = speedTickets < 4;
            bool qualified = (oldEnough && ticketNum && (duiTicket != true));
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();

        }
    }
}
