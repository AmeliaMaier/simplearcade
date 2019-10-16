using System;
using System.Collections.Generic;

namespace SimpleArcade
{
    public class GuessMyNumberGame : GameInterface
    {
        private string instructions;
        private string gameName;
        private int correctNumber;
        private int? lastGuess;

        void guessmynumbergame ()
        {
            instructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try. Type 'Quite' if you would like to return to the main menu.";
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

        public bool playTurn()
        {
            int currentGuessDiff = -1;
            int lastGuessDiff = -1;
            int currentGuess;
            Console.WriteLine("Enter guess: ");
            string userInput = Console.ReadLine();
            if(!int.TryParse(userInput, out currentGuess))
            {
                if(userInput == "Quite")
                {
                    Console.WriteLine("Closing Game.");
                    return true;
                }else
                {
                    Console.WriteLine("That number is not recognized. Please try again.");
                    return false;
                }
            }
            currentGuess = int.Parse(userInput);
            currentGuessDiff = Math.Abs(currentGuess - correctNumber);
            if (currentGuessDiff == 0)
            {
                Console.WriteLine("Correct!");
                return true;
            }else if (currentGuessDiff <= 5)
            {
                Console.WriteLine("You are burning up; so close.");
            }else if (lastGuess.HasValue)
            {
                lastGuessDiff = Math.Abs(lastGuess.Value - correctNumber);
                if(lastGuessDiff > currentGuessDiff)
                {
                    Console.WriteLine("You are getting warmer.");
                }else if (lastGuessDiff == currentGuessDiff)
                {
                    Console.WriteLine("You are staying static.");
                }else{
                    Console.WriteLine("You are getting colder.");
                }
            }else if (currentGuessDiff <= 15)
            {
                Console.WriteLine("You are warm.");
            }else if (currentGuessDiff <= 30)
            {
                Console.WriteLine("You are cool.");
            }else{
                Console.WriteLine("You are cold.");
            }
            lastGuess = currentGuess;
            return false;
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