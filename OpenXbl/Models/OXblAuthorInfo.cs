namespace khaydarics.OpenXbl.Models;

public class OXblAuthorInfo {
	public required string ModernGamertag { get; set; }

	public required string ModernGamertagSuffix { get; set; }

	public required string Name { get; set; }

	public required string SecondName { get; set; }

	public required string ImageUrl { get; set; }

	public required OXblAuthorColor Color { get; set; }

	public required string ShowAsAvatar { get; set; }

	public required string AuthorType { get; set; }

	public required string Id { get; set; }
}