using System;
using Xunit;

namespace SimpleArcade.Tests
{
    public class RandomUtilityTests
    {
        [Fact]
        public void randomNumberInBounds()
        {
            RandomUtility rand = new RandomUtility();
            int actualRandomNumber = rand.getRandomNumber(1, 2);
            Assert.True(actualRandomNumber == 1 || actualRandomNumber == 2);
        }

        [Fact]
        public void randomNumberNegative()
        {
            RandomUtility rand = new RandomUtility();
            int actualRandomNumber = rand.getRandomNumber(-10, -1);
            Assert.True(actualRandomNumber < 0);
        }

        [Fact]
        public void randomNumberPositive()
        {
            RandomUtility rand = new RandomUtility();
            int actualRandomNumber = rand.getRandomNumber(1, 10);
            Assert.True(actualRandomNumber > 0);
        }


        [Fact]
        public void randomNumberNotNull()
        {
            RandomUtility rand = new RandomUtility();
            int actualRandomNumber = rand.getRandomNumber(-100, 100);
            Assert.NotNull(actualRandomNumber);
        }
    }
}