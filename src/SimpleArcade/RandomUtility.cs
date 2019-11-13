namespace SimpleArcade
{
    public class RandomUtility
    {

        public int getLowerBound()
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

        public int getUpperBound(int lowerBound)
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

        public int getRandomNumber(int lowerBound, int upperBound)
        {
            Random rnd = new Random();
            return rnd.Next(lowerBound, upperBound + 1);
        }

    }
}