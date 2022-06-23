using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class DateDescriptors : SmartEnum<DateDescriptors, string>
{
    public static readonly DateDescriptors LastWeek = new DateDescriptors(nameof(LastWeek), "lastWeek");
    public static readonly DateDescriptors ThisWeek = new DateDescriptors(nameof(ThisWeek), "thisWeek");
    public static readonly DateDescriptors NextWeek = new DateDescriptors(nameof(NextWeek), "nextWeek");
    public static readonly DateDescriptors ThisMonth = new DateDescriptors(nameof(ThisMonth), "thisMonth");

    private DateDescriptors(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}