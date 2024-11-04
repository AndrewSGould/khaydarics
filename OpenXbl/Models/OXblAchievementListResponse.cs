namespace khaydarics.OpenXbl.Models;


public class OXblAchievementListResponse {
	public required string Xuid { get; set; }

	public required List<OXblTitle> Titles { get; set; }
}

