namespace mmmPizza.MarvelSdk;

public class MissingApiKeyException : Exception
{
    public MissingApiKeyException(string? message) : base(message)
    {
    }
    
    public readonly string Reason = "Occurs when the apikey parameter is not included with a request.";
}