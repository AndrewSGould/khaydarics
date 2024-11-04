using System.Text.Json.Serialization;

namespace khaydarics.Helper;

public interface IHttpHelper {
	Task<TResponse> SendHttpRequest<TRequest, TResponse>(HttpMethod method, string url, TRequest requestData, IDictionary<string, string>? headers = null);
	Task<TResponse> SendHttpRequest<TResponse>(HttpMethod method, string url, IDictionary<string, string>? headers = null);

	Task<TResponse> SendHttpRequest<TRequest, TResponse, TConverter>(
		HttpMethod method,
		string url,
		TRequest requestData,
		IDictionary<string, string>? headers = null,
		TConverter? customConverter = null)
			where TConverter : JsonConverter<TResponse>;

	Task<TResponse> SendHttpRequest<TResponse, TConverter>(
		HttpMethod method,
		string url,
		IDictionary<string, string>? headers = null,
		TConverter? customConverter = null)
			where TConverter : JsonConverter<TResponse>;
}
