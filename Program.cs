using Mission02;

internal class Program
{
    private static void Main(string[] args)
    {
        //ask user how many rolls they want
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        
        int numRolls = int.Parse(System.Console.ReadLine());

        //simulate rolls
        DiceRoll diceRoll = new DiceRoll();
        int[] aTotals = diceRoll.RollDice(numRolls);

        //print results
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" repersents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls + "\n");

        //for each number
        for (int i = 2; i <= 12; i++)
        {
            //print number
            //calculate % of the times it was rolled
            double pct = (aTotals[i] / (double)numRolls) * 100;
            string stars = new string('*', (int)pct);
            
            //print 1 * for each percent it was rolled
            System.Console.WriteLine(i + ": " + stars);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing stimulator. Goodbye!");
    }
}