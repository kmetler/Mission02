using Mission02;

internal class Program
{
    private static void Main(string[] args)
    {
        //ask user how many rolls they want
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        
        int numRolls = int.Parse(System.Console.ReadLine());
        // create array for totals of dice
        int[] aTotals = new int[13];

        //simulate rolls
        DiceRoll diceRoll = new DiceRoll();
        diceRoll.RollDice(numRolls, aTotals);
        
        //print results
        PrintResult printResult = new PrintResult();
        printResult.PrintOffResults(numRolls, aTotals);
    }
}