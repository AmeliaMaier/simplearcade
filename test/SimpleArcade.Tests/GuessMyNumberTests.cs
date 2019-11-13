using System;
using Xunit;

namespace SimpleArcade.Tests
{
    public class GuessMyNumberTests
    {
        [Fact]
        public void gameInstructions()
        {
            GuessMyNumber game = new GuessMyNumber();
            string expectedInstructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try. Type 'Quite' if you would like to return to the main menu.";
            string actualInstructions = game.getInstructions();
            Assert.Equal(expectedInstructions, actualInstructions);
        }

        [Fact]
        public void gameInstructionsNotNull()
        {
            GuessMyNumber game = new GuessMyNumber();
            string actualInstructions = game.getInstructions();
            Assert.NotNull(actualInstructions);
            Assert.NotEmpty(actualInstructions);
        }

        [Fact]
        public void gameName()
        {
            GuessMyNumber game = new GuessMyNumber();
            string expectedName = "Guess My Number";
            string actualName = game.getName();
            Assert.Equal(expectedName, actualName);
        }

        [Fact]
        public void gameNameNotNull()
        {
            GuessMyNumber game = new GuessMyNumber();
            string actualName = game.getName();
            Assert.NotNull(actualName);
            Assert.NotEmpty(actualName);
        }

        [Fact]
        public void emtpyTest()
        {
            GuessMyNumber game = new GuessMyNumber();
        }

    }
}
