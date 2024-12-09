namespace Trafikklys.Demo1;

internal class Demo1
{
    public static void Run()
    {
        var red = true;
        var yellow = false;
        var green = false;

        while (true)
        {
            Console.Clear();
            TrafikklysKonsoll.Show(red, yellow, green);
            if (red && !yellow)
            {
                yellow = true;
            }
            else if (red)
            {
                red = false;
                yellow = false;
                green = true;
            }
            else if (green)
            {
                green = false;
                yellow = true;
            }
            else if (yellow)
            {
                yellow = false;
                red = true;
            }

            Console.ReadKey(true);
        }
    }
}
