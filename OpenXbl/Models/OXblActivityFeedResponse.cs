namespace khaydarics.OpenXbl.Models;

public class OXblActivityFeedResponse {
	public int NumItems { get; set; }

	public required List<OXblActivityFeedItem> ActivityItems { get; set; }

	public required string PollingToken { get; set; }

	public required string PollingIntervalSeconds { get; set; }

	public required string ContToken { get; set; }
}