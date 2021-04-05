using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        // Void isn't going to return anything.
        // Static - static means a ref to the class itself, not instantiated
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Joshua Vedane";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            //Reset Text Color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            while (true)
            {



                // Set correct number
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get user's input
                    string inputNumber = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Please enter a real number, numbskull");
                        Console.ResetColor();

                        //keep going if good.
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wrong Number, please try again");
                        Console.ResetColor();
                    }
                }

                // Output Success Message
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Correct! You have won the game");
                Console.ResetColor();

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]?");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }else if(answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
