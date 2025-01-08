using ClickerOOP;

var game = new ClickerGame();
var commands = new Commands(game);

while (true)
{
    Console.Clear();
    Console.WriteLine("Kommandoer:\r\n" +
                      "- SPACE = klikk (og få poeng)\r\n" +
                      "- K = kjøp oppgradering \r\nØker poeng per klikk koster 10 poeng\r\n" +
                      "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n" +
                      "- X = avslutt applikasjonen");
    Console.WriteLine($"Du har {game.Points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Console.ReadKey().KeyChar;
    commands.Run(command);
} 