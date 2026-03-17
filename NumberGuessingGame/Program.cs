namespace NumberGuessingGame;

public abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("""
                          Welcome to the Number Guessing Game!
                          I'm thinking of a number between 1 and 100.
                          You have 3-10 chances to guess the correct number.

                          Please select the difficulty level:
                          1. Easy (10 chances)
                          2. Medium (5 chances)
                          3. Hard (3 chances)
                          """);
        
        var dict = PickDifficulty.PickYourDifficulty();
        var choiceNumber = dict.Keys.FirstOrDefault();
        var difficultyText = dict[choiceNumber];

        Console.WriteLine($"Great! You have selected the {difficultyText} difficulty level.");
        Console.WriteLine("Let's start the game!");

        GuessedNumber.GuessTheNumber(choiceNumber);

        Console.WriteLine("Thank you for playing the number guessing game!");
        Console.ReadLine();
    }
}