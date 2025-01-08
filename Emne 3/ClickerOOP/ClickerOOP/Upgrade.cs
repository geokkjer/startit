namespace ClickerOOP;

public class Upgrade: ICommand
{
    private ClickerGame _game;

    public Upgrade(ClickerGame game)
    {
        _game = game;
    }

    public char Character { get; } = 'K';

    public void Run()
    {
        _game.Upgrade();
    }
}