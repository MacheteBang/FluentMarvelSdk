namespace FluentMarvelSdk;

public sealed class SeriesOrderBy : ResourceOrderBy
{
    public static readonly SeriesOrderBy TitleAsc = new SeriesOrderBy(nameof(TitleAsc), "title");
    public static readonly SeriesOrderBy TitleDesc = new SeriesOrderBy(nameof(TitleDesc), "-title");
    public static readonly SeriesOrderBy StartYearAsc = new SeriesOrderBy(nameof(StartYearAsc), "startYear");
    public static readonly SeriesOrderBy StartYearDesc = new SeriesOrderBy(nameof(StartYearDesc), "-startYear");

    private SeriesOrderBy(string name, string value) : base(name, value) { }
}