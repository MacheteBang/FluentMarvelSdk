namespace FluentMarvelSdk;

public class Creator
{
    public int? Id { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? Lastname { get; set; }
    public string? Suffix { get; set; }
    public string? FullName { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? ResourceUri { get; set; }
    public IEnumerable<Url>? Urls { get; set; }
    public Image? Thumbnail { get; set; }
    public Catalog<SeriesSummary>? Series { get; set; }
    public Catalog<StorySummary>? Stories { get; set; }
    public Catalog<ComicSummary>? Comics { get; set; }
    public Catalog<EventSummary>? Events { get; set; }
}