
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 19th, 2016
 * Description : Assignment 4 Project 1 Dice Roll
 * Version : 1.1 - 
 *                  Change Project name
 */
namespace Assignment_4_Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // pseudo random number object
            List<int> diceRolls = new List<int>();// List that hold the dice result
            int maxRoll = 36000;// roll the dice 36000 times
            int[] tally = new int[13];// array tally hold value 0-13
            for (int i = 0; i < maxRoll; i++)
            {
                int firstDice = random.Next(1, 7);// First Dice
                int secondDice = random.Next(1, 7);// Second Dice
                int dice = firstDice + secondDice;// First Dice Add Second Dice
                diceRolls.Add(dice);// Add each dice roll result to the list dice roll
                tally[dice]++;// every time we get a result add 1 to tally
            }

            diceRolls.Sort();
            // Display the result
            foreach (int result in diceRolls)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine("\n");

            for (int i = 2; i < 13; i++)// display the number of result for each number
            {
                Console.WriteLine("{0}: {1}   {2}", i, tally[i]);
            }

        }
    }
}
