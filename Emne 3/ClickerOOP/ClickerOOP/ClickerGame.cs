namespace ClickerOOP;

public class ClickerGame : ICommand
{ 
 public int Points {get; private set;}
 public int PointsPerClick {get; private set;}
 public int PointsPerClickIncrease {get; private set;}

 public ClickerGame(int points, int pointsPerClick, int pointsPerClickIncrease)
 {
  Points = points;
  PointsPerClick = pointsPerClick;
  PointsPerClickIncrease = pointsPerClickIncrease;
 }

 public void Run()
 {
  while (true)
  {
   Console.Clear();
   Console.WriteLine("Kommandoer:\r\n" +
                     "- SPACE = klikk (og få poeng)\r\n" +
                     "- K = kjøp oppgradering \r\nØker poeng per klikk koster 10 poeng\r\n" +
                     "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                     "- X = avslutt applikasjonen");
   Console.WriteLine($"Du har {Points} poeng.");
   Console.WriteLine("Trykk tast for ønsket kommando.");
   var command = Console.ReadKey().KeyChar;
   if (command == 'x'){  Exit(); }
   else if (command == ' ') { Click(); }
   else if (command == 'k' && Points >= 10) { Upgrade(); }
   else if (command == 's' && Points >= 100) { SuperUpgrade(); } }
 }
 void Click()
 {
  Points += PointsPerClick;
 }
 void Upgrade()
 {
  Points -= 10;
  PointsPerClick += PointsPerClickIncrease;
 }

 void SuperUpgrade()
 {
  Points -= 100;
  PointsPerClickIncrease++;
 }
 void Exit()
 {
  Environment.Exit(0); 
 }
 
 
}