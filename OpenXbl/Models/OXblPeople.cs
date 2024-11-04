namespace khaydarics.OpenXbl.Models;

public class OXblPeople {
	public required string Xuid { get; set; }

	public bool IsFavorite { get; set; }

	public bool IsFollowingCaller { get; set; }

	public bool IsFollowedByCaller { get; set; }

	public bool IsIdentityShared { get; set; }

	public DateTime? AddedDateTimeUtc { get; set; }

	public required string DisplayName { get; set; }

	public required string RealName { get; set; }

	public required string DisplayPicRaw { get; set; }

	public required string ShowUserAsAvatar { get; set; }

	public required string Gamertag { get; set; }

	public required string GamerScore { get; set; }

	public required string ModernGamertag { get; set; }

	public required string ModernGamertagSuffix { get; set; }

	public required string UniqueModernGamertag { get; set; }

	public required string XboxOneRep { get; set; }

	public required string PresenceState { get; set; }

	public required string PresenceText { get; set; }

	public required object PresenceDevices { get; set; }

	public bool IsBroadcasting { get; set; }

	public bool? IsCloaked { get; set; }

	public bool IsQuarantined { get; set; }

	public bool IsXbox360Gamerpic { get; set; }

	public DateTime? LastSeenDateTimeUtc { get; set; }

	public required object Suggestion { get; set; }

	public required object Recommendation { get; set; }

	public required object Search { get; set; }

	public required object TitleHistory { get; set; }

	public required object MultiplayerSummary { get; set; }

	public required object RecentPlayer { get; set; }

	public required object Follower { get; set; }

	public required OXblPreferredColor PreferredColor { get; set; }

	public required object PresenceDetails { get; set; }

	public required object TitlePresence { get; set; }

	public required object TitleSummaries { get; set; }

	public required object PresenceTitleIds { get; set; }

	public required object Detail { get; set; }

	public required object CommunityManagerTitles { get; set; }

	public required object SocialManager { get; set; }

	public required object Broadcast { get; set; }

	public required object Avatar { get; set; }

	public required List<OXblLinkedAccount> LinkedAccounts { get; set; }

	public required string ColorTheme { get; set; }

	public required string PreferredFlag { get; set; }

	public required List<string> PreferredPlatforms { get; set; }
}
