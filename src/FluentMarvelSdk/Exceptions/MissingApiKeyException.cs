namespace FluentMarvelSdk;

public class MissingApiKeyException : Exception
{
    public MissingApiKeyException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when the apikey parameter is not included with a request.";
    public ApiError ApiError { get; init; }
}