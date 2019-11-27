using System;
using Xunit;

namespace SimpleArcade.Tests
{
    public class RandomUtilityTests
    {
        private  IUserInterface ui = new SimpleArcade.Tests.ConsoleUI();

        [Fact]
        public void randomNumberInBounds()
        {
            RandomUtility rand = new RandomUtility(ui);
            int actualRandomNumber = rand.getRandomNumber(1, 2);
            Assert.True(actualRandomNumber == 1 || actualRandomNumber == 2);
        }

        [Fact]
        public void randomNumberNegative()
        {
            RandomUtility rand = new RandomUtility(ui);
            int actualRandomNumber = rand.getRandomNumber(-10, -1);
            Assert.True(actualRandomNumber < 0);
        }

        [Fact]
        public void randomNumberPositive()
        {
            RandomUtility rand = new RandomUtility(ui);
            int actualRandomNumber = rand.getRandomNumber(1, 10);
            Assert.True(actualRandomNumber > 0);
        }


        [Fact]
        public void randomNumberNotNull()
        {
            RandomUtility rand = new RandomUtility(ui);
            int actualRandomNumber = rand.getRandomNumber(-100, 100);
            Assert.NotNull(actualRandomNumber);
        }

        // getLowerBound - valid int pos
        // getLowerBound - valid int neg
        // getLowerBound - string not int
        // getLowerBound - double not int
        // getLowerBound - null not int
        // getLowerBound - huge int ---how to handle?
        // getLowerBound - huge string ---how to handle?

        // getUpperBound - valid int pos
        // getUpperBound - valid int neg
        // getUpperBound - invalid int pos (too low)
        // getUpperBound - invalid int neg (to low)
        // getUpperBound - string not int
        // getUpperBound - double not int
        // getUpperBound - null not int
        // getUpperBound - huge int ---how to handle?
        // getUpperBound - huge string ---how to handle?
    }
}