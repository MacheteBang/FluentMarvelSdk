namespace FluentMarvelSdk;

public class Character
{
    public int? Id { get; set; }
    public string? Name { get; set; } = default!;
    public string? Description { get; set; } = default!;
    public DateTimeOffset? Modified { get; set; }
    public string? ResourceUri { get; set; } = default!;
    public IEnumerable<Url>? Urls { get; set; } = default!;
    public Image? Thumbnail { get; set; } = default!;
    public Catalog<ComicSummary>? Comics { get; set; } = default!;
    public Catalog<StorySummary>? Stories { get; set; } = default!;
    public Catalog<EventSummary>? Events { get; set; } = default!;
    public Catalog<SeriesSummary>? Series { get; set; } = default!;
}