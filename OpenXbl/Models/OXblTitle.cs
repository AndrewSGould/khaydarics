namespace khaydarics.OpenXbl.Models;

public class OXblTitle {
	public required string TitleId { get; set; }

	public string? Pfn { get; set; }

	public string? BingId { get; set; }

	public string? WindowsPhoneProductId { get; set; }

	public required string Name { get; set; }

	public required string Type { get; set; }

	public required List<string> Devices { get; set; }

	public string? DisplayImage { get; set; }

	public string? MediaItemType { get; set; }

	public string? ModernTitleId { get; set; }

	public bool? IsBundle { get; set; }

	public required OXblListAchievement Achievement { get; set; }

	public required OXblStats Stats { get; set; }

	public object? GamePass { get; set; }

	public object? Images { get; set; }

	public required OXblTitleHistory TitleHistory { get; set; }

	public object? TitleRecord { get; set; }

	public object? Detail { get; set; }

	public object? FriendsWhoPlayed { get; set; }

	public object? AlternateTitleIds { get; set; }

	public object? ContentBoards { get; set; }

	public string? XboxLiveTier { get; set; }
}