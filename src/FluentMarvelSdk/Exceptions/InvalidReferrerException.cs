namespace FluentMarvelSdk;

public class InvalidReferrerException : Exception
{
    public InvalidReferrerException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when a referrer which is not valid for the passed apikey parameter is sent.";
    public ApiError ApiError { get; init; }
}