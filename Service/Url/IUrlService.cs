using Url_Shortner_Backend.DTOs.Url;

namespace Url_Shortner_Backend.Service.Url;

public interface IUrlService
{
    public Task<List<UrlResponseDto>> GetAllUrls();
    public Task<UrlResponseDto> GetOriginalUrl(string shortUrl);
    public Task<UrlResponseDto> CreateShortUrl(UrlRequestDto urlRequestDto);
    public Task<UrlResponseDto> UpdateShortUrl(UrlRequestDto urlRequestDto);
    public Task<UrlResponseDto> DeleteShortUrl(string shortUrl);
    
}