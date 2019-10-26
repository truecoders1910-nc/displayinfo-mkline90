using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.

            // Ask user for first and last name input
            Console.WriteLine("Enter your first name and last name");
            string userName = Console.ReadLine();

            // Ask user for favorite number input
            Console.WriteLine("Enter favorite number");
            int userNumber = int.Parse(Console.ReadLine());

            // Ask user for favorite animal input
            Console.WriteLine("Enter favorite animal");
            string userAnimal = Console.ReadLine();

            // Display user input back to them in sentence form
            // If number is greater than 10, display in green
            // If number is less than  5, display in red
            Console.WriteLine($"Your name is {userName}");


            if (userNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your favorite number is {userNumber}");
                Console.ResetColor();

            }

            else if (userNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your favorite number is {userNumber}");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine($"Your favorite number is {userNumber}");
            }

            Console.WriteLine($"Your favorite animal is {userAnimal}");
        }
    }
}
