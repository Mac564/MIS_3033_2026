// Number Guessing Game
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the number guessing game!");

        Random r = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Get lower bound
            int lowerBound;
            Console.WriteLine("Please input the lower bound value (lowest value that can be guessed):");
            while (!int.TryParse(Console.ReadLine(), out lowerBound))
            {
                Console.WriteLine("Invalid number, please input a lower bound:");
            }

            // Get upper bound (must be >= lowerBound)
            int upperBound;
            Console.WriteLine("Please input the upper bound value (must be >= lower bound):");
            while (true)
            {
                string upperInput = Console.ReadLine();
                if (int.TryParse(upperInput, out upperBound) && upperBound >= lowerBound)
                    break;

                Console.WriteLine("Invalid number, please input an upper bound >= lower bound:");
            }

            // Pick the random number
            int randomNumber = r.Next(lowerBound, upperBound + 1);
            // Console.WriteLine($"(Debug) The random number is {randomNumber}");

            int attempts = 0;   // <-- declare attempts OUTSIDE the guessing loop
            int guess;

            // Guessing loop
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine($"Please guess a number between {lowerBound} and {upperBound}:");

                string guessInput = Console.ReadLine();
                if (!int.TryParse(guessInput, out guess))
                {
                    Console.WriteLine("That wasn't a valid number. Try again.");
                    continue; // don't count invalid inputs
                }

                if (guess < lowerBound || guess > upperBound)
                {
                    Console.WriteLine("Your guess is out of bounds. Try again.");
                    continue; // don't count out-of-bounds inputs
                }

                attempts++; // count each valid, in-bounds guess

                if (guess < randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Too low!");
                    Console.ResetColor();
                }
                else if (guess > randomNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Too high!");
                    Console.ResetColor();
                }
                else // guess == randomNumber
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You guessed it right in {attempts} guesses!");
                    Console.ResetColor();
                    break;
                }
            }

            // Play again?
            Console.WriteLine("Would you like to play again? (y/n)");
            string playAgainInput = (Console.ReadLine() ?? "").Trim().ToLower();
            playAgain = (playAgainInput == "y" || playAgainInput == "yes");

            if (!playAgain)
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
