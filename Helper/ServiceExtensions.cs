using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace khaydarics.Helper;
public static class ServiceExtensions {
	public static void AddHttpClients(this IServiceCollection services)
	{
		services.AddHttpClient<IHttpHelper, HttpHelper>();
	}
}

public class ExcludeHealthCheckFilter : IDocumentFilter {
	public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
	{
		swaggerDoc.Paths.Remove("/");
	}
}