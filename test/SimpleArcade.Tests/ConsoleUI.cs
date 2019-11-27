namespace SimpleArcade.Tests
{
    public class ConsoleUI : IUserInterface
    {

        public void Write(string message)
        {
            return message;
        }

        public void WriteLine(string message)
        {
            return message;
        }

        public string ReadLine(string result)
        {
            return result;
        }
    }
}