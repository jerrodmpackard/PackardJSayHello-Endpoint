using Microsoft.AspNetCore.Mvc;

namespace PackardJSayHello_Endpoint.Controllers;

[ApiController]
[Route("[Controller]")]

public class SayHello : ControllerBase
{
    [HttpPost]
    [Route("AddName/{newName}")]

    public string AddName(string newName)
    {
        return $"Hello, {newName}. Nice to meet you!";
    }
}