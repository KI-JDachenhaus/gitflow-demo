var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello KI!");

app.MapGet("/health", () => "Healthy");

app.Run();
