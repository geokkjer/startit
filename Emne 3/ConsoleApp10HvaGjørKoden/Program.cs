var range = 250;
var counts = new int[range];
int totalLetters = 0;
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    Console.Clear();
    Console.WriteLine(String.Format("{0,-6} - {1,-7} - {2,-7}", "Antall", "Bokstav", "Prosent"));
    foreach (var character in text.ToLower() ?? string.Empty)
    {
        totalLetters++;
        counts[(int)character]++;
    }

    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            // Måtte jukse litt for jeg hadde: var percentage =  counts[i] / totalLetters  * 100; som var feil matte
            var character = (char)i;
            var percentage = 100 * counts[i] / totalLetters ;
            // string output = counts[i]  + " - " + character + " - " + percentage + "%";
            
            Console.WriteLine(String.Format("{0,-6} - {1,-7} - {2,-7}", counts[i], character, percentage + "%"));
        }
    }
}