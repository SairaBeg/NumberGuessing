using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    internal class Methods
    {




   

   public  string checkNum(int guess, int correctNum, string enteredName)
    {
        string res;
        if (guess == correctNum)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "That's correct! It was " + guess + ". You win, " + enteredName + ".";

        }
        else if (guess > correctNum)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return "Your guess is greater than the correct number, try again.";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return "Your guess is lower than the correct number, try again";
        }
    }

       public bool guessIsCorrect(int guess, int correctNum)
        {
            if (guess == correctNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

   public     int checkIfNum(string input, int guess)
        {
            bool valid = false;
            while (!valid)
            {
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number");
                    Console.ResetColor();
                    input = Console.ReadLine();
                }
                else
                {
                    valid = true;
                }



            }
            return guess;

        }
    }
 }