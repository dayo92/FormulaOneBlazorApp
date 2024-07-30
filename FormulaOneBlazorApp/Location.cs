namespace Formula1BlazorApp.Data;

public class Location
{
    private string _Teams;
    private string _City;
    private string _StartDate;
    private string _TrackName;
    
        
    public string City
    {
        get { return _City; }
        set { _City = value; }
    }
    
    public string StartDate
    {
        get { return _StartDate; }
        set { _StartDate = value; }
    }
    
    public string TrackName
    {
        get { return _TrackName; }
        set { _TrackName = value; }
    }
}