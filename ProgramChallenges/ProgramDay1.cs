public static class ProgramDay1 
{
    public static void Run(string[] args) 
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello Program.cs Bootcamp");

        app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");

        app.Run();
    }
}