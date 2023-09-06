using System;

namespace NumberInput {
    class Program {
        static void Main(string[] args)
        {
            int numericValue;
            bool validNumber;

            do 
            {
                Console.WriteLine("Enter an integer value between 5 and 10:");
                string ? readResult = Console.ReadLine();

                validNumber = int.TryParse(readResult, out numericValue);

                if (validNumber)
                {
                    if (numericValue >= 5 && numericValue <= 10)
                    {
                    Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                    break; // Exit the loop since a valid number was entered
                    }
                    else
                    {
                         Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                }

             } while (true);
        }
    }
}