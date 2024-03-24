using JWT.Token.JwtHandling;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToken()
        {
            return Ok(new JwtGenerator().GenerateToken());
        }
    }
}
