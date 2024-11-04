using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace khaydarics.Helper;

public static class ControllerBaseExtensions {
	public static async Task<IActionResult> HandleHttpRequest(this ControllerBase controller, ILogger logger, Func<Task<IActionResult>> httpRequestFunc, string errorMessage)
	{
		try {
			return await httpRequestFunc();
		}
		catch (JsonException e) {
			logger.LogError(e, "JSON parsing error occurred: {Message}", e.Message);
			return controller.StatusCode(400, $"Parsing error. Please try again later.");
		}
		catch (HttpRequestException e) {
			logger.LogError(e, errorMessage);
			return controller.StatusCode(500, $"Request failed. Please try again later.");
		}
		catch (Exception e) {
			logger.LogError(e, "Uncaught error occurred");
			return controller.StatusCode(500, "An unexpected error occurred. Please try again later.");
		}
	}
}

public class BaseController : ControllerBase {
	protected Dictionary<string, string> GetHeaders()
	{
		return new Dictionary<string, string>
		{
			{ "Content-Type", "application/json" },
			{ "X-Contract", HttpContext.Request.Headers["X-Contract"].ToString() },
			{ "x-authorization", HttpContext.Request.Headers["x-authorization"].ToString() },
		};
	}
}