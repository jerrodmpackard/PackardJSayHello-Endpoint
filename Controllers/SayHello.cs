using Microsoft.AspNetCore.Mvc;

namespace PackardJSayHello_Endpoint.Controllers;

[ApiController]
[Route("[Controller]")]
public class SayHello : ControllerBase
{
    public string userName = "";

    [HttpPost]
    [Route("AddName/{newName}")]
    public string AddName(string newName)
    {
        userName = newName;
        return $"Hello, {userName}. Nice to meet you!";
    }
}
