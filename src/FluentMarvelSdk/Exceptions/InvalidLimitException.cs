namespace FluentMarvelSdk;

public class InvalidLimitException : Exception
{
    public InvalidLimitException(ApiError? error = null) : base($"From Marvel Comics API: {error?.Message ?? error?.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when a limit is out of bounds.";
    public ApiError? ApiError { get; init; }
}