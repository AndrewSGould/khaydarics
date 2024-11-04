using khaydarics.Helper;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Text.Json;
using static khaydarics.Helper.HttpHelper;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, services, configuration) => configuration
	.ReadFrom.Configuration(context.Configuration)
);

builder.Services.AddControllers(options => {
	options.Filters.Add<LoggingActionFilter>();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
	options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

	// Exclude specific endpoints like the health check from Swagger
	options.DocumentFilter<ExcludeHealthCheckFilter>();
});

builder.Services.AddHttpClients();

builder.Services.Configure<JsonOptions>(options => {
	options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try {
	Log.Information("Starting up the application - Instance ID: {InstanceId}", Guid.NewGuid());
	app.MapGet("/", () => "Healthy!!");
	app.Run();
}
catch (Exception ex) {
	Log.Fatal(ex, "The application terminated unexpectedly");
}
finally {
	Log.CloseAndFlush();
}
