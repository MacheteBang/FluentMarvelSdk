namespace FluentMarvelSdk;

public class EmptyParameterException : Exception
{
    public EmptyParameterException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }

    public readonly string Reason = "Occurs when a passed parameter is empty";
    public ApiError ApiError { get; init; }
}