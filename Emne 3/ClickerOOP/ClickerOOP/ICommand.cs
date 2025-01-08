namespace ClickerOOP;

public interface ICommand
{
    public void Run();
    char Character { get; }
}