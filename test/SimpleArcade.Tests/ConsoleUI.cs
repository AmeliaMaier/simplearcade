using System.Linq;
namespace SimpleArcade.Tests
{
    public class ConsoleUI : IUserInterface
    {
        public List<String> LinesToRead = new List<String>();
        public List<String> LinesToWrite = new List<String>();

        public void SetLinesToRead(List<String> ltr)
        {
            LinesToRead = ltr;
        }

        public void ClearLinesToWrite()
        {
            LinesToWrite = new List<String>();
        }

        public List<String> GetLinesToWrite()
        {
            return LinesToWrite;
        }

        public void Write(string message)
        {
            LinesToWrite.Append(message);
        }

        public void WriteLine(string message)
        {
            LinesToWrite.Append(message + '\n');
        }

        public string ReadLine()
        {
            string result = LinesToRead[0];
            LinesToRead.RemoveAt(0);
            return result;
        }
    }
}