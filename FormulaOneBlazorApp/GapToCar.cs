namespace Formula1BlazorApp.Data;

public class GapToCar
{
    private int _Gap;
    private int _GapToCarInFront;
    private int _GapToLeader;
        
    public int GapToCarInFront
    {
        get { return _GapToCarInFront; }
        set { _GapToCarInFront = value; }
    }
    
    public int GapToLeader
    {
        get { return _GapToLeader; }
        set { _GapToLeader = value; }
    }
}