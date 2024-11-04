namespace khaydarics.OpenXbl.Models;

public class OXblStatsResponse {
	public required List<OXblStatTitle> Titles { get; set; }

	public required OXblPagingInfo PagingInfo { get; set; }
}
