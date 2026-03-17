using System.IO;

namespace NumberGuessingGame;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("""
                          Welcome to the Number Guessing Game!
                          I'm thinking of a number between 1 and 100.
                          You have 5 chances to guess the correct number.

                          Please select the difficulty level:
                          1. Easy (10 chances)
                          2. Medium (5 chances)
                          3. Hard (3 chances)
                          """);

        bool isValidChoice;
        int choiceNumber;
        do
        {
            Console.Write("\nWhat is your choice? ");
            var choice = Console.ReadLine();
            isValidChoice = int.TryParse(choice, out choiceNumber);

            if (!isValidChoice || choiceNumber is < 1 or > 3)
                Console.WriteLine("Please enter a valid number.");
        } while (!isValidChoice || choiceNumber is < 1 or > 3);

        switch (choiceNumber)
        {
            case 1:
                Console.WriteLine("Great! You have selected the Easy difficulty level.");
                break;
            case 2:
                Console.WriteLine("Great! You have selected the Medium difficulty level.");
                break;
            case 3:
                Console.WriteLine("Great! You have selected the Hard difficulty level.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }


        Console.WriteLine("Let's start the game!");
        
        var theNumber = GuessedNumber.TheNumber();
        var availableChances = GuessedNumber.YourChances(choiceNumber);
        var attemptsTaken = 1;

        int guessedNumber;
        bool isValidGuess;
        
        do
        {
            Console.Write("\nEnter your guess: ");

            var guess = Console.ReadLine();
            isValidGuess = int.TryParse(guess, out guessedNumber);

            if (!isValidGuess)
                Console.WriteLine("Invalid entry!");
            else if (guessedNumber is < 1 or > 100)
                Console.WriteLine("Oops! I'm thinking of a number between 1 and 100.");
            else if (availableChances <= attemptsTaken)
            {
                Console.WriteLine("You have lost all the chances to guess the correct number.");
                Console.WriteLine($"The number is {theNumber}.");
                return;
            }
            else
            {
                if (guessedNumber == theNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number in {attemptsTaken} attempts.");
                    return;
                }

                Console.WriteLine(guessedNumber < theNumber
                    ? $"Incorrect! The number is greater than {guessedNumber}."
                    : $"Incorrect! The number is less than {guessedNumber}.");

                attemptsTaken++;
            }
        } while (!isValidGuess || guessedNumber is < 1 or > 100 || availableChances >= attemptsTaken);
        
        Console.WriteLine("Thank you for playing the number guessing game!");
        Console.ReadLine();
    }
}