using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace khaydarics.Helper;

public class HttpHelper : IHttpHelper {
	private readonly HttpClient _client;

	public HttpHelper(HttpClient client)
	{
		_client = client;
	}

	public async Task<TResponse> SendHttpRequest<TRequest, TResponse>(HttpMethod method, string url, TRequest requestData, IDictionary<string, string>? headers = null)
	{
		return await SendHttpRequestInternal<TRequest, TResponse>(method, url, requestData, headers);
	}

	public async Task<TResponse> SendHttpRequest<TResponse>(HttpMethod method, string url, IDictionary<string, string>? headers = null)
	{
		return await SendHttpRequestInternal<object, TResponse>(method, url, null, headers);
	}

	public async Task<TResponse> SendHttpRequest<TResponse, TConverter>(HttpMethod method, string url, IDictionary<string, string>? headers = null, TConverter? customConverter = null) where TConverter : JsonConverter<TResponse>
	{
		return await SendHttpRequestInternal<object, TResponse>(method, url, null, headers, customConverter);
	}

	public async Task<TResponse> SendHttpRequest<TRequest, TResponse, TConverter>(HttpMethod method, string url, TRequest requestData, IDictionary<string, string>? headers = null, TConverter? customConverter = null)
			where TConverter : JsonConverter<TResponse>
	{
		return await SendHttpRequestInternal(method, url, requestData, headers, customConverter);
	}

	private async Task<TResponse> SendHttpRequestInternal<TRequest, TResponse>(HttpMethod method, string url, TRequest? requestData, IDictionary<string, string>? headers = null, JsonConverter<TResponse>? customConverter = null)
	{
		var requestMessage = new HttpRequestMessage(method, url);

		if (headers != null) {
			foreach (var header in headers) {
				requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
			}
		}

		var jsonOptions = new JsonSerializerOptions {
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase
		};

		if (requestData != null && (method == HttpMethod.Post || method == HttpMethod.Put)) {
			var json = JsonSerializer.Serialize(requestData, jsonOptions);
			requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
		}

		var response = await _client.SendAsync(requestMessage);
		response.EnsureSuccessStatusCode();

		var responseBody = await response.Content.ReadAsStringAsync();
		if (string.IsNullOrEmpty(responseBody)) {
			throw new InvalidOperationException("Response body is null or empty.");
		}

		if (customConverter != null) {
			jsonOptions.Converters.Add(customConverter);
		}

		var responseData = JsonSerializer.Deserialize<TResponse>(responseBody, jsonOptions);
		if (responseData == null) {
			throw new InvalidOperationException("Deserialization of the response failed or returned null.");
		}

		return responseData;
	}

	public class LoggingActionFilter : IAsyncActionFilter {
		private readonly ILogger<LoggingActionFilter> _logger;

		public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
		{
			_logger = logger;
		}

		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			var controllerName = context.Controller.GetType().Name;
			var actionName = context.ActionDescriptor.DisplayName;
			_logger.LogInformation($"Executing {controllerName}/{actionName}");

			await next();
		}
	}
}
