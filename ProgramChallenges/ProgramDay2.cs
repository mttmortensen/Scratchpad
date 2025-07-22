namespace ProgramChallenges
{
    public static class ProgramDay2
    {
        public static void Run(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);

            // Adding controllers to the services via DI
            builder.Services.AddControllers();

            var app = builder.Build();
            
            // Telling the app to use Controller routing instead of using MapGet()
            app.MapControllers();

            app.Run();
        }
    }
}
