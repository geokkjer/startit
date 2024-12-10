namespace Trafikklys.Demo4;

public class Trafikklys
{ 
    private int _phase;

    public void SetPhase(int phase)
    {
        if (phase >= 0 && phase <= 3)
        {
            _phase = phase;
        }
    }
    public void Show()
   {
       var red = _phase < 2;
       var yellow = _phase is 1 or 3;
       var green = _phase == 2;
       
       TrafikklysKonsoll.Show(red, yellow, green);   
   }

    public void GoToNextPhase()
    {
        _phase = _phase < 3 ? _phase + 1 : 0;
    }
}