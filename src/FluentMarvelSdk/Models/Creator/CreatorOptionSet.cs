namespace FluentMarvelSdk;

public class CreatorOptionSet : OptionSet
{
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? Suffix { get; set; }
    public string? NameStartsWith { get; set; }
    public string? FirstNameStartsWith { get; set; }
    public string? MiddleNameStartsWith { get; set; }
    public string? LastNameStartsWith { get; set; }
    public int[]? Comics { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Stories { get; set; }
    public CreatorOrderBy? OrderBy { get; set; }
}