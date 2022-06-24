namespace FluentMarvelSdk;

public class MissingHashException: Exception
{
    public MissingHashException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when an apikey parameter is included with a request, a ts parameter is present, but no hash parameter is sent. Occurs on server-side applications only.";
    public ApiError ApiError { get; init; }
}