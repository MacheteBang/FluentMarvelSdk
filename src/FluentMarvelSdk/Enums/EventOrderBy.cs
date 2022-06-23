using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class EventOrderBy : SmartEnum<CharacterOrderBy, string>
{
    public static readonly EventOrderBy NameAsc = new EventOrderBy(nameof(NameAsc), "name");
    public static readonly EventOrderBy NameDesc = new EventOrderBy(nameof(NameDesc), "-name");
    public static readonly EventOrderBy StartDateAsc = new EventOrderBy(nameof(StartDateAsc), "startDate");
    public static readonly EventOrderBy StartDateDesc = new EventOrderBy(nameof(StartDateDesc), "-startDate");
    public static readonly EventOrderBy ModifiedAsc = new EventOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly EventOrderBy ModifiedDesc = new EventOrderBy(nameof(ModifiedDesc), "-modified");

    private EventOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}