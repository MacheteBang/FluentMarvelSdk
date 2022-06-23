namespace FluentMarvelSdk;

public class StoryOptionSet :OptionSet
{
    public int[]? Comics { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public SeriesOrderBy? OrderBy { get; set; }
}