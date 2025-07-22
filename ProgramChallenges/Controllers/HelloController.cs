using Microsoft.AspNetCore.Mvc;

namespace ProgramChallenges.Controllers
{
    [ApiController]
    // "/hello/"
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        // "/hello/sayhi/"
        [HttpGet("sayhi")]
        public string SayHi() 
        {
            return "Hello from Controller!";
        }
    }
}
