namespace FluentMarvelSdk;

public class EventOptionSet : OptionSet
{
    public string? Name { get; set; }
    public string? NameStartsWith { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public int[]? Series { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Stories { get; set; }
    public EventOrderBy? OrderBy { get; set; }
}