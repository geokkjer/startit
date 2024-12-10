namespace Trafikklys.Demo4;

public class Demo4
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