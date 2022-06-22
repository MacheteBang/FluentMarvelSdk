namespace mmmPizza.MarvelSdk;

public class StoryOptionSet
{
    public DateTimeOffset? ModifiedSince { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public SeriesOrderBy? OrderBy { get; set; }
    public int? Limit { get; set; }
    public int? Offiset { get; set; }
}