using System;
using System.Collections.Generic;

namespace SimpleArcade
{
    public class GuessMyNumberGame : GameInterface
    {
        private string instructions;
        private string gameName;
        private int correctNumber;
        private int lastGuess;

        void guessmynumbergame ()
        {
            instructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try.";
            gameName = "Guess My Number";
            correctNumber = getCorrectNumber();
        }

        public string getInstructions()
        {
            return instructions;
        }

        public string getName()
        {
            return gameName;
        }

        private int getCorrectNumber()
        {
            int lowerBound = getLowerBound();
            int upperBound = getUpperBound(lowerBound);
            return getRandomNumber(lowerBound, upperBound);
        }

        private int getLowerBound()
        {
            bool notInt = true;
            int lowerBound = 0;
            string userInput;
            while (notInt)
            {
                Console.WriteLine("Enter your lower bound: ");
                userInput = Console.ReadLine();
                if(int.TryParse(userInput, out lowerBound))
                {
                    notInt = false;
                    lowerBound = int.Parse(userInput);
                }else
                {
                    Console.WriteLine("That number is not recognized. Please try again.");
                }
            }    
            return lowerBound;
        }

        private int getUpperBound(int lowerBound)
        {
            bool notInt = true;
            int upperBound = 0;
            string userInput;
            while (notInt)
            {
                Console.WriteLine("Enter your upper bound: ");
                userInput = Console.ReadLine();
                if(int.TryParse(userInput, out lowerBound))
                {
                    notInt = false;
                    upperBound = int.Parse(userInput);

                    if(upperBound <= lowerBound)
                    {
                        notInt = true;
                        Console.WriteLine("Your upper bound is not greater than your lower bound. Please try again.");
                    }
                }else
                {
                    Console.WriteLine("That number is not recognized. Please try again.");
                }
            } 
            return upperBound;
        }

        private int getRandomNumber(int lowerBound, int upperBound)
        {
            Random rnd = new Random();
            return rnd.Next(lowerBound, upperBound + 1); 
        }

    }
}