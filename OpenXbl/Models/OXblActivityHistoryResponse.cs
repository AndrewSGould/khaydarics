namespace khaydarics.OpenXbl.Models;

public class OXblActivityHistoryResponse {
	public int NumItems { get; set; }

	public required List<OXblActivityHistoryItem> ActivityItems { get; set; }

	public required string PollingToken { get; set; }

	public required string PollingIntervalSeconds { get; set; }

	public required string ContToken { get; set; }
}

