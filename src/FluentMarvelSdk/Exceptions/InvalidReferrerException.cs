namespace FluentMarvelSdk;

public class InvalidReferrerException : Exception
{
    public InvalidReferrerException(string? message) : base(message)
    {
    }
    
    public readonly string Reason = "Occurs when a referrer which is not valid for the passed apikey parameter is sent.";
}