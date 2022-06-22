using System.Text.Json.Serialization;

namespace mmmPizza.MarvelSdk;

public class CharacterOptions
{
    public string? Name { get; set; }
    public string? NameStartsWith { get; set; }
    public DateTimeOffset? ModifiedSince { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Stories { get; set; }
    public CharacterOrderBy? OrderBy { get; set; }
    public int? Limit { get; set; }
    public int? Offset { get; set; }
}