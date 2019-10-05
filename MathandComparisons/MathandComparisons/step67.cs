using System;

namespace MathandComparisons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string rate1 = Console.ReadLine();
            double hourRate1 = Convert.ToDouble(rate1);
            Console.WriteLine("How many hours per week do you work?");
            string hours1 = Console.ReadLine();
            double hoursPerWeek1 = Convert.ToDouble(hours1);
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string rate2 = Console.ReadLine();
            double hourRate2 = Convert.ToDobule(rate2);
            Console.WriteLine("How many hours per week do you work?");
            string hours2 = Console.ReadLine();
            double hoursPerWeek2 = Convert.ToDouble(hours2);
            double weeklySalary1 = hourRate1 * hoursPerWeek1;
            Console.WriteLine("Weekly salary of Person 1: " + weeklySalary1);
            double weeklySalary2 = hourRate2 * hoursPerWeek2;
            Console.WriteLine("Weekly salary of Person 2: " + weeklySalary2);
            bool compare = weeklySalary1 > weeklySalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare);
        }
    }
}