namespace mmmPizza.MarvelSdk;

public class EventOptionSet
{
    public string? Name { get; set; }
    public string? NameStartsWith { get; set; }

    public DateTimeOffset? ModifiedSince { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public int[]? Series { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Stories { get; set; }
    public EventOrderBy? OrderBy { get; set; }
    public int? Limit { get; set; }
    public int? Offiset { get; set; }
}