namespace Formula1BlazorApp.Data;

public class Teams
{
    private string _Teams;
    private string _CountryOfOrigin;
        
    public string TeamName
    {
        get { return _Teams; }
        set { _Teams = value; }
    }
    
    public string CountryOfOrigin
    {
        get { return _CountryOfOrigin; }
        set { _CountryOfOrigin = value; }
    }
}