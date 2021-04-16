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
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for user's name and greet them

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
                        // Print error message 
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number...");

                        //keep going if good.
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                      // Print Error Message 
                      PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again.");
                    }
                }

                // Output Success Message
                PrintColorMessage(ConsoleColor.Yellow, "Correct! You have won the game!");

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

        // Get and display the application info
        static void GetAppInfo(){
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

        }

        // Greet user upon the start of the game
        static void GreetUser(){
          // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        // Print color Message 
        static void PrintColorMessage(ConsoleColor color, string message) {
          Console.ForegroundColor = color;
          Console.WriteLine(message);
          Console.ResetColor();
        }


    }
}
