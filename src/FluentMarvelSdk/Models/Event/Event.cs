namespace FluentMarvelSdk;

public class Event
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ResourceUri { get; set; }
    public IEnumerable<Url>? Urls { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public DateTimeOffset? Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public Image? Thumbnail { get; set; }
    public Catalog<ComicSummary>? Comics { get; set; }
    public Catalog<StorySummary>? Stories { get; set; }
    public Catalog<SeriesSummary>? Series { get; set; }
    public Catalog<CharacterSummary>? Characters { get; set; }
    public Catalog<CreatorSummary>? Creators { get; set; }
    public EventSummary? Next { get; set; }
    public EventSummary? Previous { get; set; }
}