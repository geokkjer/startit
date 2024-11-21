namespace EssentialCsharp
{
    public class Tekst
    {
        public static void Main()
        {
            var tekst = new TextObject[]
            {
                new TextObject
                {
                    Text = "Geir",
                    FontSize = 14,
                    FontColor = 00001,
                    Color = ConsoleColor.Green,
                },
                new TextObject
                {
                    Text = "Geir2",
                    FontSize = 12,
                    FontColor = 010001,
                    Color = ConsoleColor.Gray,
                }
            };
            foreach (var tekst1 in tekst)
            {
                tekst1.Print();
                Thread.Sleep(100);
            }

        }
    }
}

