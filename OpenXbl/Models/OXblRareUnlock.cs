namespace khaydarics.OpenXbl.Models;

public class OXblRareUnlock {
	public required string RarityCategory { get; set; }

	public int NumUnlocks { get; set; }

	public bool IsRarestCategory { get; set; }
}
