namespace FluentMarvelSdk;

public class MissingHashException: Exception
{
    public MissingHashException(string? message) : base(message)
    {
    }
    
    public readonly string Reason = "Occurs when an apikey parameter is included with a request, a ts parameter is present, but no hash parameter is sent. Occurs on server-side applications only.";
}