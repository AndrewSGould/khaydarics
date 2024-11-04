namespace khaydarics.OpenXbl.Models;

public class OXblLoginResponse {
	public required string ApiKey { get; set; }
	public required string Xuid { get; set; }
	public required string Gamertag { get; set; }
	public string? Avatar { get; set; }
	public string? Email { get; set; }
}
