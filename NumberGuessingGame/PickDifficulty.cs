namespace NumberGuessingGame;

public abstract class PickDifficulty
{
    public static Dictionary<int, string> PickYourDifficulty()
    {
        var dict = new Dictionary<int, string>();
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

        dict[choiceNumber] = DifficultyText(choiceNumber);
        return dict;
    }

    private static string DifficultyText(int choiceNumber) => choiceNumber switch
    {
        1 => "Easy",
        2 => "Medium",
        3 => "Hard"
    };
}