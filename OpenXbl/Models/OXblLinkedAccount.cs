namespace khaydarics.OpenXbl.Models;

public class OXblLinkedAccount {
	public required string NetworkName { get; set; }

	public required string DisplayName { get; set; }

	public bool ShowOnProfile { get; set; }

	public bool IsFamilyFriendly { get; set; }

	public required object Deeplink { get; set; }
}