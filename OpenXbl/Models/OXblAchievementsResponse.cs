namespace khaydarics.OpenXbl.Models;

public class OXblAchievementsResponse {
	public required List<OXblAchievement> Achievements { get; set; }

	public required OXblPagingInfo PagingInfo { get; set; }
}