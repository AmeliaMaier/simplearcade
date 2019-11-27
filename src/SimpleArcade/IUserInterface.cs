// adding for testability based on https://stackoverflow.com/questions/3161341/c-sharp-unit-test-for-a-method-which-calls-console-readline

namespace SimpleArcade
{
    public interface IUserInterface
    {
        void Write(string message);
        void WriteLine(string message);
        string ReadLine();
    }
}