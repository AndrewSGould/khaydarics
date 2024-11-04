namespace khaydarics.OpenXbl.Models;

public class OXblGameMediaContentLocator {
	public DateTime Expiration { get; set; }

	public long FileSize { get; set; }

	public string? LocatorType { get; set; }

	public Uri? Uri { get; set; }
}