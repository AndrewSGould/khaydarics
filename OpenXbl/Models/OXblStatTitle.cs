namespace khaydarics.OpenXbl.Models;

public class OXblStatTitle {
	public DateTime LastUnlock { get; set; }

	public long TitleId { get; set; }

	public required string ServiceConfigId { get; set; }

	public required string TitleType { get; set; }

	public required string Platform { get; set; }

	public required string Name { get; set; }

	public int EarnedAchievements { get; set; }

	public int CurrentGamerscore { get; set; }

	public int MaxGamerscore { get; set; }

	public required List<OXblRareUnlock> RareUnlocks { get; set; }
}