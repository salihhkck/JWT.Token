using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Token.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TokenAccessController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok("Products");
        }
    }
}
