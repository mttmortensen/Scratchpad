using Microsoft.AspNetCore.Mvc;

namespace ProgramChallenges.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("sayhi")]
        public string SayHi() 
        {
            return "Hello from Controller!";
        }
    }
}
