using System.Text.Json;
using System.Text.Json.Serialization;

namespace FluentMarvelSdk;

internal class MarvelDateTimeConverter : JsonConverter<DateTimeOffset>
{
	private readonly string _format;

	public MarvelDateTimeConverter(string format)
	{
		_format = format;
	}

    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
		return DateTime.ParseExact(reader.GetString() ?? "", _format, null);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
		writer.WriteStringValue(value.ToString(_format));
    }
}