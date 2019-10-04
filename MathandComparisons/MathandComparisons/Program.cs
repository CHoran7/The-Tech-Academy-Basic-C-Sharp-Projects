using System;

namespace MathandComparisons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please provide a number:");
            string userNum = Console.ReadLine();
            int integerNum = Convert.ToInt32(userNum);
            int multipliedNum = integerNum * 50;
            Console.WriteLine(userNum + " multiplied by 50 = " + multipliedNum);
            Console.WriteLine("Provide another number:");
            string userNum2 = Console.ReadLine();
            int integerNum2 = Convert.ToInt32(userNum2);
            int addedNum = integerNum2 + 25;
            Console.WriteLine(integerNum2 + " plus 25 is " + addedNum);
            Console.WriteLine("Provide another number:");
            string userNum3 = Console.ReadLine();
            double num3 = Convert.ToDouble(userNum3);
            double divNum = num3 / 12.5;
            Console.WriteLine(num3 + "divided by 12.5 is " + divNum);
            Console.WriteLine("Provide another number:");
            string userNum4 = Console.ReadLine();
            int compareNum = Convert.ToInt32(userNum4);
            bool compare = compareNum > 50;
            string boolean = Convert.ToString(compare);
            Console.WriteLine("Your number is greater than 50 is " + boolean);
            Console.WriteLine("Provide one last number:");
            string userNum5 = Console.ReadLine();
            int remain = Convert.ToInt32(userNum5);
            int remainder = remain % 7;
            Console.WriteLine(remain + " divided by 7 has a remainder of " + remainder);
            Console.ReadLine();
        }
    }
}
