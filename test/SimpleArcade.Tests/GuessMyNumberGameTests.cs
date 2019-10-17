using System;
using Xunit;

namespace SimpleArcade.Tests
{
    public class GuessMyNumberGameTests
    {
        [Fact]
        public void checkGameInstructions()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string expectedInstructions = "Enter an upper and lower bound. A random integer between the bounds will be created. Each turn, try to guess the number. You will be given hints as you try. Type 'Quite' if you would like to return to the main menu.";
            string actualInstructions = game.getInstructions();
            Assert.Equal(expectedInstructions, actualInstructions);
        }

        [Fact]
        public void checkGameName()
        {
            GuessMyNumberGame game = new GuessMyNumberGame();
            string expectedName = "Guess My Number";
            string actualName = game.getName();
            Assert.Equal(expectedName, actualName);
        }

    }
}
