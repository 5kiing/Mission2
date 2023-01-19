using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variables
            Random r = new Random();

            int[] rollTotals = new int[13];
            int timesThrown = 0;

            // roll total range
            rollTotals[0] = r.Next(6);

            // prompt user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? ");
            timesThrown = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // receive user input


            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.Write("Total number of rolls = " + timesThrown + ".\n");

            Console.WriteLine();

            
            // simulate roll of the die
            for (int i = 0; i < timesThrown; i++)
            {
                int roll1 = r.Next(1,7);
                int roll2 = r.Next(1,7);

                int rollTot = roll1 + roll2;

                rollTotals[rollTot]++;
            }

            //print roll results
            for (int i = 2; i <= 12; i++)
            {
                int percentage = (int)((double)rollTotals[i] / timesThrown * 100);
                Console.Write(i + ": ");
                for (int x = 0; x < percentage; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
