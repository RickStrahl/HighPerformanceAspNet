using Microsoft.AspNetCore.Mvc;

namespace HighPerformanceAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassicController : ControllerBase
    {

        [HttpGet("hello")]
        public object Hello()
        {
            return new { name = "Rick", message = "Hello World" };
        }

        [HttpPost("hello")]
        public object Hello(RequestMessage model)
        {
            return new { name = "Rick", message = "Hello World" };
        }
    }
}
