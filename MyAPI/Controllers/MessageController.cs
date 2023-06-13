using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyAPI.Controllers;

[ApiController]
[Route("message")]
[Authorize]
public class MessageController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return  Ok(new { message= "Hello"});
    }
}