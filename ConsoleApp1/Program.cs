using System;

namespace CustomHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to a custom Hello World Program!");

            // Get user's name using the GetUserInput method
            string userName = GetUserInput("Please enter your name: ");

            // Display a personalized greeting using string interpolation
            Console.WriteLine($"Hello, {userName}! This program showcases some .NET console programming skills.");

            // Display the current date and time
            DisplayCurrentDateAndTime();

            // Display the .NET Core version
            DisplayFrameworkVersion();

            // Get the user's favorite number
            int favoriteNumber = GetFavoriteNumber();

            // Calculate the square of the favorite number
            int squaredNumber = CalculateSquare(favoriteNumber);

            // Display the squared number
            Console.WriteLine($"Your favorite number squared: {squaredNumber}");

            // Wait for user input before exiting
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method to get user input with a prompt
        static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        // Method to display the current date and time
        static void DisplayCurrentDateAndTime()
        {
            Console.WriteLine($"Current date and time: {DateTime.Now}");
        }

        // Method to display the .NET Core version
        static void DisplayFrameworkVersion()
        {
            Console.WriteLine(".NET Core version: " + Environment.Version);
        }

        // Method to get a valid favorite number from the user
        static int GetFavoriteNumber()
        {
            int favoriteNumber;

            while (true)
            {
                // Get user input
                string input = GetUserInput("Please enter your favorite number: ");

                // Try parsing the input as an integer
                if (int.TryParse(input, out favoriteNumber))
                {
                    break; // Exit the loop if parsing is successful
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            return favoriteNumber;
        }

        // Method to calculate the square of a number
        static int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}
