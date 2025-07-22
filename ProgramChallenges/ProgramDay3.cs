namespace ProgramChallenges
{
    public static class ProgramDay3
    {
        public static void Run(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // 1. Custom middleware (runs on every request)
            // 2. App built-in middleware for routing 
            // 3. Add an endpoint
        }
    }
}
