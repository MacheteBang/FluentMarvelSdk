namespace FluentMarvelSdk;

public class InvalidParameterException : Exception
{
    public InvalidParameterException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }

    public readonly string Reason = "Occurs when there is an invalid or unrecognized parameter.";
    public ApiError ApiError { get; init; }
}