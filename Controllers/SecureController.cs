using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAPI2
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecureController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Data()
        {
            return Ok(new { message = "This is secure data" });
        }
    }
}