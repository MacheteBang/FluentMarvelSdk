namespace FluentMarvelSdk;

public class Series
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ResourceUri { get; set; }
    public IEnumerable<Url>? Urls { get; set; }
    public int? StartYear { get; set; }
    public int? EndYear { get; set; }
    public string? Rating { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public Image? Thumbnail { get; set; }
    public Catalog<ComicSummary>? Comics { get; set; }
    public Catalog<StorySummary>? Stories { get; set; }
    public Catalog<EventSummary>? Events { get; set; }
    public Catalog<CharacterSummary>? Characters { get; set; }
    public Catalog<CreatorSummary>? Creators { get; set; }
    public SeriesSummary? Next { get; set; }
    public SeriesSummary? Previous { get; set; }
}