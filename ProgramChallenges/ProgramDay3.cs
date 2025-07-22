namespace ProgramChallenges
{
    public static class ProgramDay3
    {
        public static void Run(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // 1. Custom middleware (runs on every request)
            app.Use(async (context, next) => 
            {

                // Challenge from Chat: 
                if (context.Request.Path == "/block") 
                {
                    context.Response.StatusCode = 403;
                    Console.WriteLine($"[Middleware] Response Status: {context.Response.StatusCode}");
                    await context.Response.WriteAsync("Access Denied");
                    
                    // Doesn't call next
                    return; 
                }

                Console.WriteLine($"[Middleware] Request: {context.Request.Method} {context.Request.Path}");
                // It sends control to the next middleware in the pipeline. 
                await next.Invoke();
                Console.WriteLine($"[Middleware] Response Status: {context.Response.StatusCode}");
            });

            // 2. App built-in middleware for routing 
            // next.Invoke() would go to this middleware
            // MapControllers() would be another middleware example
            app.UseRouting();

            // 3. Add an endpoint
            app.MapGet("/", () => "Hello from Day 3!");

            app.Run();
        }
    }
}
