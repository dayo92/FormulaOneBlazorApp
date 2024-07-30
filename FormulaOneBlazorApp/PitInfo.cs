namespace Formula1BlazorApp.Data;

public class PitInfo
{
    private int _PitTime;
    private int _PitStop;
        
    public int PitTime
    {
        get { return _PitTime; }
        set { _PitTime = value; }
    }
    
    public int PitStop
    {
        get { return _PitStop; }
        set { _PitStop = value; }
    }
}