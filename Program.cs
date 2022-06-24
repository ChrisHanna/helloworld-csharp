var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Added to allow Cloud Run Listening
var port = "8080";
var url = $"http://0.0.0.0:{port}";

app.MapGet("/", () => "Hello World!");

app.Run();
