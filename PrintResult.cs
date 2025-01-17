using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{
    internal class PrintResult
    {
        public void PrintOffResults(int numRolls, int[] aTotals) 
        {
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
}
