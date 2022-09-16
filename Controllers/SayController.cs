using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SayController : ControllerBase
{
    
    [HttpGet("hello/{name}")]
    public IActionResult Get(string name)
    {
        return Ok($"Hello {name}");
    }
}