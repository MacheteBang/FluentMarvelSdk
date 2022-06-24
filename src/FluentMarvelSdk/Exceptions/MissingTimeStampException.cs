namespace FluentMarvelSdk;

public class MissingTimestampException: Exception
{
    public MissingTimestampException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when an apikey parameter is included with a request, a hash parameter is present, but no ts parameter is sent. Occurs on server-side applications only.";
    public ApiError ApiError { get; init; }
}