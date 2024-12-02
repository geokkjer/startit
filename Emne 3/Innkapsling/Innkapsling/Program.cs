
var numbers = new int[100];
var numberCount = 0;
while (true)
{
    Console.WriteLine("Skriv et tall (eller blankt for å avslutte: ");
    var numberStr = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(numberStr)) break;
     
    var number = Convert.ToInt32(numberStr);
    numbers[numberCount] = number;
    numberCount++;
    var sum = numbers.Sum();
      Console.Clear();
    Console.WriteLine(
        $"Antall tall: {numberCount} " +
        $"Sum: {sum} " +
        $"Snitt: {(float)sum / numberCount}"
        );
}