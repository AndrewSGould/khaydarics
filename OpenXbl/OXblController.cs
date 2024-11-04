using khaydarics.Helper;
using khaydarics.OpenXbl.Models;
using Microsoft.AspNetCore.Mvc;

namespace khaydarics.OpenXbl;

[ApiController]
[Route("[controller]")]
public class OXblController : BaseController {
	private readonly ILogger<OXblController> _logger;
	private readonly IHttpHelper _httpHelper;

	public OXblController(ILogger<OXblController> logger, IHttpHelper httpHelper)
	{
		_logger = logger;
		_httpHelper = httpHelper;
	}

	[HttpGet(nameof(Login))]
	public async Task<IActionResult> Login()
	{
		string code = "M.C502_BL2.2.U.e451ba03-b77f-f5d6-0f81-6bfb49008576";
		string appKey = "e2b847de-5a5a-4b4e-9b1d-ce70c4fd368e";

		string url = "https://xbl.io/app/claim";

		var requestData = new OXblLoginRequest {
			Code = code,
			App_Key = appKey
		};

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblLoginRequest, OXblLoginResponse>(HttpMethod.Post, url, requestData);
			return Ok(response);
		}, "Error occurred during OpenXbl Login");
	}

	[HttpGet(nameof(Account))]
	public async Task<IActionResult> Account()
	{
		string url = "https://xbl.io/api/v2/account";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblAccount>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl Account");
	}

	[HttpGet("profiles/{xuids}")]
	public async Task<IActionResult> Profiles(string xuids)
	{
		string url = $"https://xbl.io/api/v2/account/{xuids}";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblProfileResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl Profile");
	}

	[HttpGet("achievements/{xuid}")]
	public async Task<IActionResult> Achievements(string xuid)
	{
		string url = $"https://xbl.io/api/v2/achievements/player/{xuid}";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblAchievementListResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl Achievements");
	}

	[HttpGet("achievements/{xuid}/{titleId}")]
	public async Task<IActionResult> AchievementsForTitle(string xuid, string titleId)
	{
		string url = $"https://xbl.io/api/v2/achievements/player/{xuid}/{titleId}";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblAchievementsResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl AchievementsForTitle");
	}

	[HttpGet("achievements/x360/{xuid}/{titleId}")]
	public async Task<IActionResult> AchievementsFor360Title(string xuid, string titleId)
	{
		string url = $"https://xbl.io/api/v2/achievements/x360/{xuid}/title/{titleId}";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OxblAchievements360Response>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl AchievementsFor360Title");
	}

	[HttpGet("stats/{titleIds}")]
	public async Task<IActionResult> TitleAchievements(string titleIds)
	{
		string url = $"https://xbl.io/api/v2/achievements/{titleIds}";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblStatsResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl TitleAchievements");
	}

	[HttpGet("activity/feed")]
	public async Task<IActionResult> ActivityFeed()
	{
		string url = $"https://xbl.io/api/v2/activity/feed";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblActivityFeedResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl ActivityFeed");
	}

	[HttpGet("activity/history")]
	public async Task<IActionResult> ActivityHistory()
	{
		string url = $"https://xbl.io/api/v2/activity/history";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblActivityHistoryResponse>(HttpMethod.Get, url, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl ActivityHistory");
	}

	[HttpGet("gamepass/all")]
	public async Task<IActionResult> GamepassAll()
	{
		string url = $"https://xbl.io/api/v2/gamepass/all";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<List<OXblGamepassResponse>, OXblGamepassResponseConverter>(
					HttpMethod.Get, url, GetHeaders(), new OXblGamepassResponseConverter());
			return Ok(response);
		}, "Error occurred fetching OpenXbl GamepassAll");
	}

	[HttpGet("gamepass/pc")]
	public async Task<IActionResult> GamepassPc()
	{
		string url = $"https://xbl.io/api/v2/gamepass/pc";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<List<OXblGamepassResponse>, OXblGamepassResponseConverter>(
					HttpMethod.Get, url, GetHeaders(), new OXblGamepassResponseConverter());
			return Ok(response);
		}, "Error occurred fetching OpenXbl GamepassPc");
	}

	[HttpGet("gamepass/ea-play")]
	public async Task<IActionResult> GamepassEaPlay()
	{
		string url = $"https://xbl.io/api/v2/gamepass/ea-play";

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<List<OXblGamepassResponse>, OXblGamepassResponseConverter>(
					HttpMethod.Get, url, GetHeaders(), new OXblGamepassResponseConverter());
			return Ok(response);
		}, "Error occurred fetching OpenXbl GamepassEaPlay");
	}

	[HttpGet("marketplace/details/{productIds}")]
	public async Task<IActionResult> MarketplaceDetails(string productIds)
	{
		string url = $"https://xbl.io/api/v2/marketplace/details";

		var requestData = new OXblMarketplaceRequest { Products = productIds };

		return await this.HandleHttpRequest(_logger, async () => {
			var response = await _httpHelper.SendHttpRequest<OXblMarketplaceRequest, object>(HttpMethod.Post, url, requestData, GetHeaders());
			return Ok(response);
		}, "Error occurred fetching OpenXbl MarketplaceDetails");
	}
}
