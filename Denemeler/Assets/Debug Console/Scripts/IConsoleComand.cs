namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    public interface IConsoleComand
    {
        string CommandWord { get; }
        bool Process(string[] args);
    }
}
