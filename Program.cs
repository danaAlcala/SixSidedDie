using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SixSidedDie
{
    class Program
    {
        static Random rnd = new Random();

        /* These integers are used in the Tally() function to tally how many of each number appear for each roll. */
        static int tallyOne = 0;
        static int tallyTwo = 0;
        static int tallyThree = 0;
        static int tallyFour = 0;
        static int tallyFive = 0;
        static int tallySix = 0;
        /**/

        /* These doubles will be used to store the percentage of each roll in relation to the total number of rolls. */
        static double percentageOne = 0.0;
        static double percentageTwo = 0.0;
        static double percentageThree = 0.0;
        static double percentageFour = 0.0;
        static double percentageFive = 0.0;
        static double percentageSix = 0.0;
        /**/


        static int currentRoll = 0; // This integer will be used to store each roll as they occur.

        static int totalRolls = 0; // This integer will count the total number of rolls that have occurred.

        static void Main(string[] args)
        {
            RollTenTimes();
            Console.WriteLine("Ones: {0} ({1}%)", tallyOne, (int)(percentageOne * 100));
            Console.WriteLine("Twos: {0} ({1}%)", tallyTwo, (int)(percentageTwo * 100));
            Console.WriteLine("Threes: {0} ({1}%)", tallyThree, (int)(percentageThree * 100));
            Console.WriteLine("Fours: {0} ({1}%)", tallyFour, (int)(percentageFour * 100));
            Console.WriteLine("Fives: {0} ({1}%)", tallyFive, (int)(percentageFive * 100));
            Console.WriteLine("Sixes: {0} ({1}%)", tallySix, (int)(percentageSix * 100));

            Console.WriteLine("Total rolls: {0}", totalRolls);
            Console.ReadLine();
        } // end Main()

        static int Roll() // This function represents the rolling of a six-sided die, and returns the result.
        {
            int result = rnd.Next(1, 7);
            totalRolls++;
            return result;
        } // end Roll()

        static void Tally(int x) // This function will tally the appropriate numbers after each roll.
        {
            switch(x)
            {
                case 1: tallyOne++;
                    break;
                case 2: tallyTwo++;
                    break;
                case 3: tallyThree++;
                    break;
                case 4: tallyFour++;
                    break;
                case 5: tallyFive++;
                    break;
                case 6: tallySix++;
                    break;
                default: Error();
                    break;
            }
        } // end Tally()

        static void Error() // Generic, inefficient error-handling.
        {
            Console.WriteLine("An error has occurred.");
            Console.ReadLine();
        } // end Error()

        static void FindPercentage() // This function will find the percentage of each roll in relation to the total number of rolls.
        {
            switch (tallyOne)
            {
                case 0: percentageOne = 0.0;
                    break;
                default: percentageOne == (double)(tallyOne / totalRolls);
                    break;
            }

            switch (tallyTwo)
            {
                case 0: percentageTwo = 0.0;
                    break;
                default: percentageTwo = (double)(tallyTwo / totalRolls);
                    break;
            }

            switch (tallyThree)
            {
                case 0: percentageThree = 0.0;
                    break;
                default: percentageThree = (double)(tallyThree / totalRolls);
                    break;
            }

            switch (tallyFour)
            {
                case 0: percentageFour = 0.0;
                    break;
                default: percentageFour = (double)(tallyFour / totalRolls);
                    break;
            }

            switch (tallyFive)
            {
                case 0: percentageFive = 0.0;
                    break;
                default: percentageFive = (double)(tallyFive / totalRolls);
                    break;
            }

            switch (tallySix)
            {
                case 0: percentageSix = 0.0;
                    break;
                default: percentageSix = (double)(tallySix / totalRolls);
                    break;
            }
        } // end FindPercentage()

        static void ClearData()
        {
            tallyOne = tallyTwo = tallyThree = tallyFour = tallyFive = tallyFive = tallySix = 0;
            percentageOne = percentageTwo = percentageThree = percentageFour = percentageFive = percentageSix = 0.0;
            totalRolls = 0;
            currentRoll = 0;
        }

        static void RollTenTimes()
        {
            for (int i = 1; i <= 10; i++)
            {
                currentRoll = Roll();
                Console.WriteLine(currentRoll);
                Tally(currentRoll);
            }
            FindPercentage();
        }

        static void Roll100Times()
        {
        }

        static void Roll1000Times()
        {
        }

        static void Roll10000Times()
        {
        }

        static void Roll100000Times()
        {
        }

        static void Roll1000000Times()
        {
        }
    } // end Class
} // end Namespace
