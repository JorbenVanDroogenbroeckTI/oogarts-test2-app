﻿using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Oogarts.Client.Files;

public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
	private const string Format = "dd/MM/yyyy";

	public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return DateOnly.ParseExact(reader.GetString()!, Format, CultureInfo.InvariantCulture);
	}

	public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
	}
}