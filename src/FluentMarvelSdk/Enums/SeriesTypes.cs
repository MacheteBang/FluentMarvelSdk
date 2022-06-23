using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class SeriesTypes : SmartEnum<SeriesTypes, string>
{
    public static readonly SeriesTypes Collection = new SeriesTypes(nameof(Collection), "collection");
    public static readonly SeriesTypes OneShot = new SeriesTypes(nameof(OneShot), "one shot");
    public static readonly SeriesTypes Limited = new SeriesTypes(nameof(Limited), "limited");
    public static readonly SeriesTypes Ongoing = new SeriesTypes(nameof(Ongoing), "ongoing");

    private SeriesTypes(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}