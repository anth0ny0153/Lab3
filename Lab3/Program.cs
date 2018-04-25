using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //used to run the program again
            {
                Console.WriteLine("Hi! What's your name?");
                string userName = Console.ReadLine();
                Console.WriteLine($"Hey there {userName}! Please enter an integer between 1 and 100");
                int chosenNumber = int.Parse(Console.ReadLine());

                if (chosenNumber % 2 != 0 & chosenNumber <= 100 & chosenNumber > 0) //if the number is odd, less than or equal to 100 and greater than 0 it executes this statement
                    {
                        Console.WriteLine(userName + ", your number is odd");
                        if (chosenNumber >= 60)
                        {
                            Console.WriteLine(" and greater than 60");
                        }
                    }
                    else if (chosenNumber <= 100 & chosenNumber > 0) //if the number is even, less than or equal to 100 and greater than 0 it executes
                    {
                        if (chosenNumber <= 25)
                        {
                            Console.WriteLine(userName + ", your number is even and less than 25.");
                        }
                        else if (chosenNumber <= 60)
                        {
                            Console.WriteLine(userName + ", your number is even and between 26 and 60");
                        }
                        else
                        {
                            Console.WriteLine(userName + ", your number is even and greater than 60");
                        }
                    }

                    else //if it doesnt execute the two loops before that means the number isnt between 1-100
                    {
                        Console.WriteLine("Sorry what you entered isn't in the parameters");
                    }
                Console.WriteLine("Do you want to run the program again? (yes/no)");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            }
        }
    }
}
