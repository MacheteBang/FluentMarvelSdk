namespace FluentMarvelSdk;

public class InvalidLimitException : Exception
{
    public InvalidLimitException(ApiError? error = null) : base($"From Marvel Comics API: {error?.Message ?? error?.Status}")
    {
        ApiError = error;
    }
    
    public readonly string Reason = "Occurs when a limit is less than 0 or greater than 100.";
    public ApiError? ApiError { get; init; }
}