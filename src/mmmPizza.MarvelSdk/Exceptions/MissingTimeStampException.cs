namespace mmmPizza.MarvelSdk;

public class MissingTimestampException: Exception
{
    public readonly string Reason = "Occurs when an apikey parameter is included with a request, a hash parameter is present, but no ts parameter is sent. Occurs on server-side applications only.";
}