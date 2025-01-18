using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission02
{
    internal class DiceRoll
    {
        private Random rnd = new Random();

        public int[] RollDice (int numRolls)
        {
            // create array for totals of dice
            int[] aTotals = new int[13];

            //for the number of times they said
            for (int i = 0; i < numRolls; i++)
            {
                //generate a random number 1-6
                int randNum1 = rnd.Next(1, 7);
                //generate second random number 1-6
                int randNum2 = rnd.Next(1, 7);

                //Add two numbers together
                int total = randNum1 + randNum2;

                //go update counter of each number
                aTotals[total]++;
            }

            return aTotals;
        }
    }
}
