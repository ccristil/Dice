using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class diceGame
    {
        private Random random = new Random();

        public void PlayGame(int g) {
            int die1 = 0;
            int die2 = 0;
            int total = 0;
            string output = "DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = " + g + "\r\n\r\n";
            string results = "";
            int[] rollTotals = new int[13];


            for (int i = 0; i <= g; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                rollTotals[total]++;
            }
          

            for (int i  = 2; i <= 12; i++)
            {
                string asterisks = "";
                int percentage = 0;
                double doubleg = (double)g;

                percentage = (int)(rollTotals[i] / doubleg * 100);

                for (int n = 1; n <= percentage; n++) 
                {
                    asterisks += "*";
                }

                results += i + ": " + asterisks + "\r\n";

            }
            output += results;
            output += "\r\nThank you for playing the dice throwing simulator! See ya later!";
            System.Console.WriteLine(output);
   
        }
    }
}
