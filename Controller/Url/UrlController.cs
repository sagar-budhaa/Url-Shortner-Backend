using Microsoft.AspNetCore.Mvc;
using Url_Shortner_Backend.DTOs.Url;
using Url_Shortner_Backend.Service.Url;

namespace Url_Shortner_Backend.Controller.Url;

[ApiController]
[Route("api/[controller]")]
public class UrlController(IUrlService urlService) : ControllerBase
{

    [HttpGet]
    public ActionResult<List<UrlResponseDto>> Get()
    {
        var urls = urlService.GetAllUrls().Result;
        return Ok(urls);
    }
    
}