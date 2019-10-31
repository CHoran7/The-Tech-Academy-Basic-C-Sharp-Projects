using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number: ");
            string userNum = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Cole\Documents\log2.txt", userNum);
            string text = File.ReadAllText(@"C:\Users\Cole\Documents\log2.txt");
            Console.WriteLine(text);
            Console.Read();
        }
    }
}
