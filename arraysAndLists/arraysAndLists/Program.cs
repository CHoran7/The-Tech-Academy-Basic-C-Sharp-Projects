using System;
using System.Collections.Generic;

namespace arraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] strArray = { "red", "blue", "green", "pink" };
            Console.WriteLine("Pick a number 0-3.");
            int index1 = Convert.ToInt32(Console.ReadLine());
            if (index1 < 4 && index1 >= 0)
            {
                Console.WriteLine(strArray[index1]);
            }
            else
            {
                Console.WriteLine("Please pick a number from 0-3 next time.");
            }
            

            int[] intArray = { 1, 1, 2, 3, 5, 8, 13 };
            Console.WriteLine("Pick a number 0-6.");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 < 7 && index2 >= 0)
            {
                Console.WriteLine(intArray[index2]);
            }
            else
            {
                Console.WriteLine("Please pick a number from 0-6 next time.");
            }

            List<string> stringList = new List<string>();
            stringList.Add("Bob");
            stringList.Add("Joe");
            stringList.Add("Sue");
            stringList.Add("Mary");
            Console.WriteLine("Please pick a number from 0-3.");
            int index3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[index3]);
            Console.ReadLine();
        }
    }
}
