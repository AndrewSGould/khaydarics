using System.Text.Json;
using System.Text.Json.Serialization;

namespace khaydarics.OpenXbl.Models;

public class OXblGamepassResponse {
	public string? Id { get; set; }
}

public class TitleId : OXblGamepassResponse { }

public class OXblGamepassResponseConverter : JsonConverter<List<OXblGamepassResponse>> {
	public override List<OXblGamepassResponse> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var responses = new List<OXblGamepassResponse>();

		if (reader.TokenType == JsonTokenType.StartArray) {
			while (reader.Read()) {
				if (reader.TokenType == JsonTokenType.EndArray) break;
				var element = JsonSerializer.Deserialize<OXblGamepassResponse>(ref reader, options);
				if (element != null && element.Id != null) {
					responses.Add(element);
				}
			}
		}

		return responses;
	}

	public override void Write(Utf8JsonWriter writer, List<OXblGamepassResponse> value, JsonSerializerOptions options)
	{
		JsonSerializer.Serialize(writer, value, options);
	}
}
