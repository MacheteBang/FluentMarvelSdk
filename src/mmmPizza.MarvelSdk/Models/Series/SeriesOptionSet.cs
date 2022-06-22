namespace mmmPizza.MarvelSdk;

public class SeriesOptionSet
{
    public string? Title { get; set; }
    public string? TitleStartsWith { get; set; }
    public int? StartYear { get; set; }
    public DateTimeOffset? ModifiedSince { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Stories { get; set; }
    public int[]? Events { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public SeriesTypes? SeriesType { get; set; }
    public ComicFormats? Contains { get; set; }
    public SeriesOrderBy? OrderBy { get; set; }
    public int? Limit { get; set; }
    public int? Offiset { get; set; }
}