namespace Trafikklys.Demo3;

public class Demo3
{
    public static void Run()
    {
        var trafikklys = new Trafikklys();
        while (true)
        { 
            Console.Clear(); 
            trafikklys.Show(); 
            Console.ReadKey(true); 
            trafikklys.GoToNextPhase();
        }
    }
}