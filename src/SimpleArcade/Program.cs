using System;
using System.Collections.Generic;

namespace SimpleArcade
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = 0;
            while (menuSelection != 5)
            {
                Console.WriteLine("Simple Arcade");
                Console.WriteLine("1. Guess My Number");
                Console.WriteLine("2. Hangman");
                Console.WriteLine("3. TicTacToe");
                Console.WriteLine("4. History");
                Console.WriteLine("5. Quite");
                menuSelection = Console.Read();

                switch (menuSelection)
                {
                    case 1:
                        GuessMyNumberGame game = new GuessMyNumberGame();
                        Console.WriteLine(game.getName());
                        Console.WriteLine(game.getInstructions());
                        while(!game.playTurn()){}
                        break;
                    case 2:
                        Console.WriteLine("Hangman pending code");
                        break;
                    case 3:
                        Console.WriteLine("TicTacToe pending code");
                        break;
                    case 4:
                        Console.WriteLine("History pending code");
                        break;
                    case 5:
                        Console.WriteLine("Closing");
                        break;
                    default:
                        Console.WriteLine("Selection not recognized. Please choose a number from the menu.");
                        break;
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
