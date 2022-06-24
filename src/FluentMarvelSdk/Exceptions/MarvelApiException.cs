namespace FluentMarvelSdk;

public class MarvelApiException : Exception
{
    public MarvelApiException(ApiError error) : base("User error when using Marvel API. See `Reason` for details.")
    {
        ApiError = error;
    }

    public ApiError ApiError { get; init; }
}