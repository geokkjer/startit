namespace ClickerOOP;

public class SuperUpgrade: ICommand
{
 private ClickerGame _game;
 public char Character { get; } = 'S';

 public SuperUpgrade(ClickerGame game)
 {
  _game = game;
 }

 public void Run()
 {
  _game.SuperUpgrade();
 }
}