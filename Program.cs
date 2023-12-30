using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;


namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Saira Beg";
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}",appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("Enter your name: ");
            string enteredName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", enteredName);

            Random rnd = new Random();
            int correctNum = rnd.Next(1,11);
            int guess = 0;
            bool numberFound = false;
            bool playing = true;
            Methods mth = new Methods();
            while (playing)
            {
                while (!numberFound && playing)
                {
                    Console.ResetColor();
                    Console.WriteLine("Guess a number between 1 and 10");

                    string input = Console.ReadLine();
                    guess = mth.checkIfNum(input, guess);

                    Console.WriteLine("you guessed " + guess);
                    Console.WriteLine(mth.checkNum(guess, correctNum, enteredName));
                    numberFound = mth.guessIsCorrect(guess, correctNum);
                    Console.ResetColor();


                }
                Console.WriteLine("Play again? [Y or N]");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "Y")
                {
                    numberFound = false;
                    correctNum = rnd.Next(1, 11);
                    guess = 0;
                  
                }
                else if (playAgain == "N")
                {
                    playing = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
            //string checkNum(int guess,int correctNum, string enteredName)
            //{
            //    string res;
            //    if (guess == correctNum)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        return "That's correct! It was " + guess + ". You win, " + enteredName + ".";

            //    }
            //    else if (guess > correctNum)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        return "Your guess is greater than the correct number, try again.";
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        return "Your guess is lower than the correct number, try again";
            //    }
            //}

            //bool guessIsCorrect(int guess, int correctNum)
            //{
            //    if (guess == correctNum)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //int checkIfNum(string input)
            //{
            //    bool valid = false;
            //    while (!valid)
            //    {
            //        if (!int.TryParse(input, out guess))
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("Please enter a valid number");
            //            Console.ResetColor();
            //            input = Console.ReadLine();
            //        }
            //        else
            //        {
            //            valid = true;
            //        }



            //    }
            //    return guess;

            //}

        }
    }
}