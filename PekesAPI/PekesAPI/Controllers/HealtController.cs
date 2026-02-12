using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pekes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealtController : ControllerBase
    {
        [HttpGet]
        public async Task<OkObjectResult> GetHealt()
        {
            return Ok("It's live");
        }
    }
}
