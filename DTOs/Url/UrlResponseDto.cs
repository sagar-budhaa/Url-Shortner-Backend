namespace Url_Shortner_Backend.DTOs.Url;

public class UrlResponseDto
{
    public string OriginalUrl { get; set; }
    public string ShortUrl { get; set; }
    public bool IsSuccess { get; set; }
}