namespace NumberGuessingGame;

public static class GuessedNumber
{
    public static void GuessTheNumber(int choiceNumber)
    {
        var theNumber = TheNumber();
        var availableChances = YourChances(choiceNumber);
        var attemptsTaken = 1;

        int guessedNumber;
        bool isValidGuess;

        do
        {
            Console.Write("\nEnter your guess: ");

            var guess = Console.ReadLine();
            isValidGuess = int.TryParse(guess, out guessedNumber);

            if (!isValidGuess)
            {
                Console.WriteLine("Invalid entry!");
            }
            else if (guessedNumber is < 1 or > 100)
            {
                Console.WriteLine("Oops! I'm thinking of a number between 1 and 100.");
            }
            else if (availableChances <= attemptsTaken)
            {
                Console.WriteLine("You have lost all the chances to guess the correct number.");
                Console.WriteLine($"The correct number is {theNumber}.");
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
    }

    private static int YourChances(int choiceNumber)
    {
        return choiceNumber switch
        {
            1 => 10,
            2 => 5,
            3 => 3,
            _ => 0
        };
    }

    private static int TheNumber()
    {
        var rnd = new Random();
        return rnd.Next(0, 101);
    }
}