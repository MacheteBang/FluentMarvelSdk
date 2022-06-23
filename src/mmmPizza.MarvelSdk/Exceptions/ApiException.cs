namespace mmmPizza.MarvelSdk;

public class ApiException : Exception
{
    public ApiException(int statusCode, string reason) : base("User error when using Marvel API. See `Reason` for details.")
    {
        StatusCode = statusCode;
        Reason = reason;
    }

    public int StatusCode { get; init; }
    public string Reason { get; init; }
}