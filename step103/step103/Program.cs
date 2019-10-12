using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step103
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            Console.WriteLine("Please provide a last name:");
            string lName = Console.ReadLine();
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + lName;
                Console.WriteLine(names[i]);
            }
            //This is the infinite loop but commented out because obviously I don't want it to actually run
            //for(int a = 0; a < 50; a--)
            //{
            //    Console.WriteLine(a);
            //}
            for(int a = 0; a < 50; a++)
            {
                Console.WriteLine(a);
            }
            
            for(int b = 0; b <= 5; b++)
            {
                Console.WriteLine(b * b);
            }

            List<string> horans = new List<string>() { "Cole", "Tucker", "CJ", "Dan" };
            Console.WriteLine("What is the name of the person you  are searching for?");
            string name = Console.ReadLine();
            for(int i = 0; i < horans.Count; i++)
            {
                if (name != horans[i] && i == 3)
                {
                    Console.WriteLine("Your search did not match any family members. Are you sure you capitalized the first letter?");
                }
                if (name == horans[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            List<string> people = new List<string>() { "Cole", "Tucker", "CJ", "Dan", "Laura", "Jack", "CJ", "Dan" };
            Console.WriteLine("What is the name of the person you  are searching for?");
            string family = Console.ReadLine();
            bool match = false;
            for (int i = 0; i < people.Count; i++)
            {
                if (family == people[i])
                {
                    Console.WriteLine(i);
                    match = true;
                }
            }

            if(match == false)
            {
                Console.WriteLine("There is no matching family member.");
            }

            List<string> copy = new List<string>();
            match = false;
            foreach (string person in people)
            {
                Console.WriteLine(person);
                for(int i = 0; i < copy.Count; i++)
                {
                    if (copy[i] == person)
                    {
                        Console.WriteLine("This person has already appeared in the list.");
                        match = true;
                    }
                }
                if (match == false)
                {
                    Console.WriteLine("This person has not appeared on the list.");
                }
                copy.Add(person);

            }
            Console.ReadLine();
        }
    }
}
