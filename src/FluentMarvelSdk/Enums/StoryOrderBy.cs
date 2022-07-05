namespace FluentMarvelSdk;

public sealed class StoryOrderBy : ResourceOrderBy
{
    public static readonly StoryOrderBy IdAsc = new StoryOrderBy(nameof(IdAsc), "id");
    public static readonly StoryOrderBy IdDesc = new StoryOrderBy(nameof(IdDesc), "-id");

    private StoryOrderBy(string name, string value) : base(name, value) { }
}