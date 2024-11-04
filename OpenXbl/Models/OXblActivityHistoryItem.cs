namespace khaydarics.OpenXbl.Models;

public class OXblActivityHistoryItem {
	public Guid ClipId { get; set; }

	public Uri? ClipThumbnail { get; set; }

	public Uri? DownloadUri { get; set; }

	public string? ClipName { get; set; }

	public string? ClipCaption { get; set; }

	public Guid ClipScid { get; set; }

	public DateTime DateRecorded { get; set; }

	public int DurationInSeconds { get; set; }

	public string? CreationType { get; set; }

	public required List<OXblGameMediaContentLocator> GameMediaContentLocators { get; set; }

	public int ViewCount { get; set; }

	public required Uri ContentImageUri { get; set; }

	public required string ContentTitle { get; set; }

	public required string Platform { get; set; }

	public required string TitleId { get; set; }

	public required string UploadTitleId { get; set; }

	public required string Description { get; set; }

	public DateTime Date { get; set; }

	public bool HasUgc { get; set; }

	public required string ActivityItemType { get; set; }

	public required string ContentType { get; set; }

	public required string ShortDescription { get; set; }

	public required string ItemText { get; set; }

	public required Uri ItemImage { get; set; }

	public required string ShareRoot { get; set; }

	public required string FeedItemId { get; set; }

	public required string ItemRoot { get; set; }

	public bool HasLiked { get; set; }

	public required OXblAuthorInfo AuthorInfo { get; set; }

	public required string UserXuid { get; set; }
}