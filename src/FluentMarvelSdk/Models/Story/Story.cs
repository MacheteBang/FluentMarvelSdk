namespace FluentMarvelSdk;

public class Story
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ResourceUri { get; set; }
    public string? Type { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public Image? Thumbnail { get; set; }
    public Catalog<ComicSummary>? Comics { get; set; }
    public Catalog<SeriesSummary>? Series { get; set; }
    public Catalog<CharacterSummary>? Characters { get; set; }
    public Catalog<CreatorSummary>? Creators { get; set; }
    public ComicSummary? OriginalIssue { get; set; }
}