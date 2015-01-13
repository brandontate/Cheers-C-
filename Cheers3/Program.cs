using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");

            //Step 1. Get User's name.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();

            //Step 2. Do a Cheer with the User's name. All Lowercase.
            for (int i = 0; i < name.Length; i++)
            {
                string letters = "halfnorsemix";
                if (letters.IndexOf(name[i]) != -1)
                {
                    System.Console.WriteLine("Give me an... " + name.ToLower()[i] + "!");
                }
                else
                {
                    System.Console.WriteLine("Give me a... " + name.ToLower()[i] + "!");
                }
            };

            //Step 3. End Cheer and print User's name. All Uppercase.
            System.Console.WriteLine(name.ToUpper() + " is... GRAND!");

            //Step 4. Ask for User's birthday.
            //Give an amount of days since their birthday. 
            //If within the last 60 days then give different output
            System.Console.WriteLine("When is your birthday? (MM/DD/YYY)");
            string dob = System.Console.ReadLine();

            DateTime birthday = Convert.ToDateTime(dob);
            DateTime today = DateTime.Today;

            int difference = (birthday - today).Days;

            if (-1 > difference && difference > -60)
            {
                System.Console.WriteLine("Aww shucks I just missed your birthday... It was " + (difference * -1) + " days ago");
            }
            else if (304 < difference && 364 > difference)
            {
                System.Console.WriteLine("Aww shucks I just missed your birthday... It was " + ((difference * -1) + 365) + " days ago");
            }
            else if (difference == 0)
            {
                System.Console.WriteLine("Today is your birthday!!!");
            }
            else
            {
                System.Console.WriteLine("Your birthday is " + difference + " days away.");
            }

            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
