namespace ClickerOOP;

public class Click: ICommand
{
    private ClickerGame _game;
    public char Character { get; } = ' ';

    public Click(ClickerGame game)
    {
        _game = game;
    }
    public void Run()
    {
        _game.Click();
    }
}