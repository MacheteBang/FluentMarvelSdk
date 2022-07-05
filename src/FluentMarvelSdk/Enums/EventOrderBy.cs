namespace FluentMarvelSdk;

public sealed class EventOrderBy : ResourceOrderBy
{
    public static readonly EventOrderBy NameAsc = new EventOrderBy(nameof(NameAsc), "name");
    public static readonly EventOrderBy NameDesc = new EventOrderBy(nameof(NameDesc), "-name");
    public static readonly EventOrderBy StartDateAsc = new EventOrderBy(nameof(StartDateAsc), "startDate");
    public static readonly EventOrderBy StartDateDesc = new EventOrderBy(nameof(StartDateDesc), "-startDate");

    private EventOrderBy(string name, string value) : base(name, value) { }
}