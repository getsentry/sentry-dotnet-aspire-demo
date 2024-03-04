using AspireWithSentry.ApiService;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Send telemetry and crash reporting to Sentry
builder.AddSentry();

// Add SQL Client
builder.AddSqlServerClient("tempdb");

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});

app.MapGet("/crashtest", Delegate(SqlConnection connection) =>
{
    using (connection)
    {
        connection.Open();
        var command = new SqlCommand(CommandHelper.CommandText, connection);
        command.ExecuteNonQuery();
    }

    throw new Exception("This is a test exception");
});


app.MapDefaultEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
