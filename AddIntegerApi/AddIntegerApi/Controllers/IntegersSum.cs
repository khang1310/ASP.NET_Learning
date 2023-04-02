using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddIntegerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegersSum : ControllerBase
    {
        [HttpGet("{num1}/{num2}")]
        public IActionResult Sum(int num1, int num2)
        {
            return Ok(num1 + num2);
            
        }
    }
}
