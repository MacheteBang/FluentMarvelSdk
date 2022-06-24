namespace FluentMarvelSdk;

public class InvalidHashException : Exception
{
    public InvalidHashException(ApiError error) : base($"From Marvel Comics API: {error.Message ?? error.Status}")
    {
        ApiError = error;
    }

    public readonly string Reason = "Occurs when a ts, hash and apikey parameter are sent but the hash is not valid per the above hash generation rule.";
    public ApiError ApiError { get; init; }
}