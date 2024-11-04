namespace khaydarics.OpenXbl.Models;

public class OXblActivityFeedItem {
	public string? AchievementScid { get; set; }

	public string? AchievementId { get; set; }

	public string? AchievementType { get; set; }

	public string? AchievementIcon { get; set; }

	public string? RarityCategory { get; set; }

	public int RarityPercentage { get; set; }

	public int Gamerscore { get; set; }

	public string? AchievementName { get; set; }

	public string? AchievementDescription { get; set; }

	public bool IsSecret { get; set; }

	public bool HasAppAward { get; set; }

	public bool HasArtAward { get; set; }

	public required string ContentImageUri { get; set; }

	public required string ContentTitle { get; set; }

	public required string Platform { get; set; }

	public required string TitleId { get; set; }

	public required string Description { get; set; }

	public DateTime Date { get; set; }

	public bool HasUgc { get; set; }

	public required string ActivityItemType { get; set; }

	public required string ContentType { get; set; }

	public required string ShortDescription { get; set; }

	public required string ItemText { get; set; }

	public required string ItemImage { get; set; }

	public required string ShareRoot { get; set; }

	public required string FeedItemId { get; set; }

	public required string ItemRoot { get; set; }

	public bool HasLiked { get; set; }

	public required OXblAuthorInfo AuthorInfo { get; set; }

	public required string UserXuid { get; set; }
}