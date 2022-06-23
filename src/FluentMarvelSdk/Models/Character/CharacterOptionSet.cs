namespace FluentMarvelSdk;

public class CharacterOptionSet : OptionSet
{
    public string? Name { get; set; }
    public string? NameStartsWith { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Stories { get; set; }
    public CharacterOrderBy? OrderBy { get; set; }
}