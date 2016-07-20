
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 19th, 2016
 * Description : Assignment 4 Project 1 Dice Roll
 * Version : 0.3 - 
 *                  Added Display and Sort function
 */
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // pseudo random number object
            List<int> diceRolls = new List<int>();// List that hold the dice result
            int maxRoll = 36000;// roll the dice 36000 times
            for (int i = 0; i < maxRoll; i++)
            {
                int firstDice = random.Next(1, 7);// First Dice
                int secondDice = random.Next(1, 7);// Second Dice
                int dice = firstDice + secondDice;// First Dice Add Second Dice
                diceRolls.Add(dice);// Add each dice roll result to the list dice roll
            }

            diceRolls.Sort();
            // Display the result
            foreach (int result in diceRolls)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine("\n");

        }
    }
}
