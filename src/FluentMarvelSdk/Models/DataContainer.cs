namespace FluentMarvelSdk;

public class DataContainer<T>
{
    // Public Properties
    public IResourceRequestBuilder<T>? Previous { get; private set; }
    public IResourceRequestBuilder<T>? Next { get; private set; }


    public int? Offset { get; set; }
    public int? Limit { get; set; }
    public int? Total { get; set; }
    public int? Count { get; set; }
    public IEnumerable<T>? Results { get; set; }

    internal void SetPreviousBuilder(IResourceRequestBuilder<T> previousBuilder)
    {
        Previous = previousBuilder;
    }

    internal void SetNextBuilder(IResourceRequestBuilder<T> nextBuilder)
    {
        Next = nextBuilder;
    }
}