using Microsoft.AspNetCore.Mvc;

namespace Url_Shortner_Backend.Controller.Home;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public RedirectResult Get()
    {
        return Redirect("scalar/v1");
    }
}