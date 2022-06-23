namespace FluentMarvelSdk;

public abstract class OptionSet
{
    public DateTimeOffset? ModifiedSince { get; set; }
    public int? Limit { get; set; }
    public int? Offset { get; set; }
}