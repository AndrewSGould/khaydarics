namespace khaydarics.OpenXbl.Models;

public class OXblPagingInfo {
	public required string ContinuationToken { get; set; }

	public int TotalRecords { get; set; }
}
