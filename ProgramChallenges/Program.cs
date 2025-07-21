namespace ProgramChallenges 
{
    public class Program() 
    {
        static void Main(string[] args)
        {

            // Builder is like the app's construction manager
            // It handles config, logging and services (DI)
            var builder = WebApplication.CreateBuilder(args);

            // Now you build the app once builder has finished configuring
            // You can't add services after this point
            var app = builder.Build();

            // MapGet adds '/' to the end of our base URL (localhost)
            // Which is determined in launchSettings.json
            // In this example it would return "Hello World" at the root URL (/)
            // app.MapGet("/", () => "Hello World!");

            // ProgramDayX is going to be a set of static classes to help
            // with having multiple top-level statements.
            ProgramDay1.Run(args);

            // This runs the app on a web server (Kestrel)
            // This blocks the main thread and listens for requests
            app.Run();
        }
    }
}