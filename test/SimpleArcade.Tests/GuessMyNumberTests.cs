using System;
using Xunit;

namespace SimpleArcade.Tests
{
    public class GuessMyNumberTests
    {
        [Fact]
        public void gameInstructions()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string expectedInstructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try. Type 'Quite' if you would like to return to the main menu.";
            string actualInstructions = game.getInstructions();
            Assert.Equal(expectedInstructions, actualInstructions);
        }

        [Fact]
        public void gameInstructionsNotNull()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string actualInstructions = game.getInstructions();
            Assert.NotNull(actualInstructions);
            Assert.NotEmpty(actualInstructions);
        }

        [Fact]
        public void gameName()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string expectedName = "Guess My Number";
            string actualName = game.getName();
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void gameNameNotNull()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string actualName = game.getName();
            Assert.NotNull(actualName);
            Assert.NotEmpty(actualName);
        }

        [Fact]
        public void randomNumberInBounds()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            int actualRandomNumber = game.getRandomNumber(1, 2);
            Assert.True(actualRandomNumber == 1 || actualRandomNumber == 2);
        }

        [Fact]
        public void randomNumberNegative()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            int actualRandomNumber = game.getRandomNumber(-10, -1);
            Assert.True(actualRandomNumber < 0);
        }

        [Fact]
        public void randomNumberPositive()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            int actualRandomNumber = game.getRandomNumber(1, 10);
            Assert.True(actualRandomNumber > 0);
        }


        [Fact]
        public void randomNumberNotNull()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            int actualRandomNumber = game.getRandomNumber(-100, 100);
            Assert.NotNull(actualRandomNumber);
        }

        [Fact]
        public void emtpyTest()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
        }

    }
}
