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
        var result = urlService.GetAllUrls().Result;
        return Ok(result);
    }



    [HttpPost]
    public ActionResult<UrlResponseDto> Post([FromBody] UrlRequestDto urlRequestDto)
    {
        var result = urlService.CreateShortUrl(urlRequestDto).Result;
        return Ok(result);
    }
    
}