namespace NumberGuessingGame;

public class GuessedNumber
{
    public static int YourChances(int choiceNumber) => choiceNumber switch
    {
        1 => 10,
        2 => 5,
        3 => 3,
        _ => 0
    };

    public static int TheNumber()
    {
        var rnd = new Random();
        return rnd.Next(0, 101);
    }

}