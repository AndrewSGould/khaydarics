namespace khaydarics.OpenXbl.Models;

public class OXblAchievement {
	public required string Id { get; set; }

	public required string ServiceConfigId { get; set; }

	public required string Name { get; set; }

	public required List<OXblTitleAssociation> TitleAssociations { get; set; }

	public required string ProgressState { get; set; }

	public required OXblProgression Progression { get; set; }

	public required List<OXblMediaAsset> MediaAssets { get; set; }

	public required List<string> Platforms { get; set; }

	public bool IsSecret { get; set; }

	public required string Description { get; set; }

	public required string LockedDescription { get; set; }

	public required string ProductId { get; set; }

	public required string AchievementType { get; set; }

	public required string ParticipationType { get; set; }

	public required object TimeWindow { get; set; }

	public required List<OXblReward> Rewards { get; set; }

	public required string EstimatedTime { get; set; }

	public required string Deeplink { get; set; }

	public bool IsRevoked { get; set; }

	public required OXblRarity Rarity { get; set; }
}
