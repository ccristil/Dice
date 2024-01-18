using Dice;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        diceGame dg = new diceGame();

        int games = 0;
        System.Console.WriteLine("Welcome to the dice throwing simulator!!");

        System.Console.WriteLine("How many dice rolls would you like to simualte?");

        string input = System.Console.ReadLine();

        if (int.TryParse(input, out games))
        {
            dg.PlayGame(games);
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please enter a valid number.");
        }

    }
}