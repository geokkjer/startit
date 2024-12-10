namespace Trafikklys.Demo2;

internal class Trafikklys
{ 
    bool red;
    bool yellow;
    bool green; 

    public Trafikklys()
    {
        red = true;
    }

    public void Show()
    {
      TrafikklysKonsoll.Show(red, yellow, green);   
    }

    public void GoToNextPhase()
    {
        if (red && !yellow)
        {
            yellow = true;
        }
        else if (red)
        {
            red = false; 
            yellow = false; 
            green = true;
        }else if (green)
        { 
            green = false; 
            yellow = true;
        }else if (yellow)
        { 
            yellow = false; 
            red = true;
        }
    }
}