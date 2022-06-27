namespace FluentMarvelSdk;

public class Comic
{
    public int? Id { get; set; }
    public int? DigitalId { get; set; }
    public string? Title { get; set; }
    public double? IssueNumber { get; set; }
    public string? VariantDescription { get; set; }
    public string? Description { get; set; }
    public DateTimeOffset Modified { get; set; }
    public string? Isbn { get; set; }
    public string? Upc { get; set; }
    public string? DiamondCode { get; set; }
    public string? Ean { get; set; }
    public string? Issn { get; set; }
    public string? Format { get; set; }
    public int? PageCount { get; set; }
    public IEnumerable<TextObject>? TextObjects { get; set; }
    public string? ResourceUri { get; set; }
    public IEnumerable<Url>? Urls { get; set; }
    public SeriesSummary? Series { get; set; }
    public IEnumerable<ComicSummary>? Variants { get; set; }
    public IEnumerable<ComicSummary>? Collections { get; set; }
    public IEnumerable<ComicSummary>? CollectedIssues { get; set; }
    public IEnumerable<ComicDate>? Dates { get; set; }
    public IEnumerable<ComicPrice>? Prices { get; set; }
    public Image? Thumbnail { get; set; }
    public IEnumerable<Image>? Images { get; set; }
    public Catalog<CreatorSummary>? Creators { get; set; }
    public Catalog<CharacterSummary>? Characters { get; set; }
    public Catalog<StorySummary>? Stories { get; set; }
    public Catalog<EventSummary>? Events { get; set; }
}
