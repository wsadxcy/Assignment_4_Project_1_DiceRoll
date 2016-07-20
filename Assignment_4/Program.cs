
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author : Chenyuan Xie
 * Date : July 19th, 2016
 * Date Modified: Jul 19th, 2016
 * Description : Assignment 4 Project 1 Dice Roll
 * Version : 0.2 - 
 *                  Added and Calculated the value of two dices
 */
namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // pseudo random number object
            int firstDice = random.Next(1, 7);// First Dice
            int secondDice = random.Next(1, 7);// Second Dice
            int dice = firstDice + secondDice;// First Dice Add Second Dice

        }
    }
}
