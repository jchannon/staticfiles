var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseFileServer(new FileServerOptions
{
    DefaultFilesOptions =
    {
        DefaultFileNames = new List<string>(new[] { "index.html" })
    }
});
app.MapGet("/qwerty", () => "Hello World!");

app.Run();