using Ardalis.SmartEnum;

public sealed class ComicFormatTypes : SmartEnum<ComicFormatTypes, string>
{
    public static readonly ComicFormatTypes Comic = new ComicFormatTypes(nameof(Comic), "comic");
    public static readonly ComicFormatTypes Collection = new ComicFormatTypes(nameof(Collection), "collection");

    private ComicFormatTypes(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}