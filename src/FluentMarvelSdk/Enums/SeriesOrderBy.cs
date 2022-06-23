using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class SeriesOrderBy : SmartEnum<SeriesOrderBy, string>
{
    public static readonly SeriesOrderBy TitleAsc = new SeriesOrderBy(nameof(TitleAsc), "title");
    public static readonly SeriesOrderBy TitleDesc = new SeriesOrderBy(nameof(TitleDesc), "-title");
    public static readonly SeriesOrderBy StartYearAsc = new SeriesOrderBy(nameof(StartYearAsc), "startYear");
    public static readonly SeriesOrderBy StartYearDesc = new SeriesOrderBy(nameof(StartYearDesc), "-startYear");
    public static readonly SeriesOrderBy ModifiedAsc = new SeriesOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly SeriesOrderBy ModifiedDesc = new SeriesOrderBy(nameof(ModifiedDesc), "-modified");

    private SeriesOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}