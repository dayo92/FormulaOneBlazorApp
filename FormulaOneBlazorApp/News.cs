namespace Formula1BlazorApp.Data;

public class News
{
    private string _Headline;
    private string _UrlToStory;
        
    public string Headline
    {
        get { return _Headline; }
        set { _Headline = value; }
    }
    
    public string UrlToStory
    {
        get { return _UrlToStory; }
        set { _UrlToStory = value; }
    }
}