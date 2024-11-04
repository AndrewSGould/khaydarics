namespace khaydarics.OpenXbl.Models;

public class OXblProfileResponse {
	public List<OXblPeople>? People { get; set; }
	public List<OXblProfile>? ProfileUsers { get; set; }

	public object? RecommendationSummary { get; set; }

	public object? FriendFinderState { get; set; }

	public object? AccountLinkDetails { get; set; }
}
