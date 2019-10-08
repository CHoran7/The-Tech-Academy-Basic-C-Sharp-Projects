using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color");
            string guess = Console.ReadLine();
            bool isGuessed = guess == "orange";

            while(!isGuessed)
            {
                switch(guess)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Congrats!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Not even close. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Guess another color");
            guess = Console.ReadLine();
            isGuessed = false;
            do
            {
                switch (guess)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. Congrats!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Not even close. Try again.");
                        Console.WriteLine("Guess a color");
                        guess = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}
