namespace khaydarics.OpenXbl.Models;

public class OXbl360Achievement {
	public int Id { get; set; }

	public long TitleId { get; set; }

	public required string Name { get; set; }

	public int Sequence { get; set; }

	public int Flags { get; set; }

	public bool UnlockedOnline { get; set; }

	public bool Unlocked { get; set; }

	public bool IsSecret { get; set; }

	public int Platform { get; set; }

	public int Gamerscore { get; set; }

	public int ImageId { get; set; }

	public required string Description { get; set; }

	public required string LockedDescription { get; set; }

	public int Type { get; set; }

	public bool IsRevoked { get; set; }

	public DateTime TimeUnlocked { get; set; }

	public required OXblRarity Rarity { get; set; }
}