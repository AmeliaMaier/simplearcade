using System;
using System.Collections.Generic;

namespace SimpleArcade
{
    /*
    need to: 
    break play turn up so it is testable
    pull out random into a util so it is testable
    */
    public class GuessMyNumberGame
    {
        private string instructions;
        private string gameName;
        private int correctNumber;
        private int? lastGuess;

        public GuessMyNumberGame ()
        {
            instructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try. Type 'Quite' if you would like to return to the main menu.";
            gameName = "Guess My Number";
        }

        public void setupCorrectNumber()
        {
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

        public int getCorrectNumber()
        {
            RandomUtility rand = new RandomUtility();
            int lowerBound = rand.getLowerBound();
            int upperBound = rand.getUpperBound(lowerBound);
            return rand.getRandomNumber(lowerBound, upperBound);
        }


    }
}