using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class CharacterOrderBy : SmartEnum<CharacterOrderBy, string>
{
    public static readonly CharacterOrderBy NameAsc = new CharacterOrderBy(nameof(NameAsc), "name");
    public static readonly CharacterOrderBy NameDesc = new CharacterOrderBy(nameof(NameDesc), "-name");
    public static readonly CharacterOrderBy ModifiedAsc = new CharacterOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly CharacterOrderBy ModifiedDesc = new CharacterOrderBy(nameof(ModifiedDesc), "-modified");

    private CharacterOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}