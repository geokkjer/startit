namespace Trafikklys.Demo3;

public class Trafikklys
{
    private bool Red { get; set; }
    public bool Yellow { get; private set; }
    public bool Green { get; private set; }

    public Trafikklys()
    { 
        Red = true;
    }
    public void Show() 
    {
        TrafikklysKonsoll.Show(Red, Yellow, Green);   
    }
    
    public void GoToNextPhase()
    {
        if (Red && !Yellow)
        {
            Yellow = true;
        }else if (Red)
        { 
            Red = false;
            Yellow = false;
            Green = true;
        }else if (Green)
        { 
            Green = false; 
            Yellow = true;
        }else if (Yellow) 
        { 
            Yellow = false; 
            Red = true;
        }
    }
}