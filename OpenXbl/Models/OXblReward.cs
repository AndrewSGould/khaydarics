namespace khaydarics.OpenXbl.Models;

public class OXblReward {
	public required string Name { get; set; }

	public required string Description { get; set; }

	public required string Value { get; set; }

	public required string Type { get; set; }

	public required object MediaAsset { get; set; }

	public required string ValueType { get; set; }
}