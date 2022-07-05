using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public class ResourceOrderBy : SmartEnum<CharacterOrderBy, string>, IResourceOrderBy
{
    public static readonly ResourceOrderBy ModifiedAsc = new ResourceOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly ResourceOrderBy ModifiedDesc = new ResourceOrderBy(nameof(ModifiedDesc), "-modified");

    internal ResourceOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}