using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class StoryOrderBy : SmartEnum<StoryOrderBy, string>
{
    public static readonly StoryOrderBy IdAsc = new StoryOrderBy(nameof(IdAsc), "id");
    public static readonly StoryOrderBy IdDesc = new StoryOrderBy(nameof(IdDesc), "-id");
    public static readonly StoryOrderBy ModifiedAsc = new StoryOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly StoryOrderBy ModifiedDesc = new StoryOrderBy(nameof(ModifiedDesc), "-modified");

    private StoryOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}