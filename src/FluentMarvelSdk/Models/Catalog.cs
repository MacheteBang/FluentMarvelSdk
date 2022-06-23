namespace FluentMarvelSdk;

public class Catalog<T>
{
    public int Available { get; set; }
    public int Returned { get; set; }
    public string CollectionUri { get; set; } = default!;
    public IEnumerable<T> Items { get; set; } = default!;
}