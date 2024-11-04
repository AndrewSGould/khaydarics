namespace khaydarics.OpenXbl.Models;
public class OXblProfileUser {
	public required string Id { get; set; }

	public required string HostId { get; set; }

	public required List<OXblSetting> Settings { get; set; }

	public bool IsSponsoredUser { get; set; }
}