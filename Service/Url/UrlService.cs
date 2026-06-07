using Url_Shortner_Backend.DTOs.Url;

namespace Url_Shortner_Backend.Service.Url;

public class UrlService : IUrlService
{
    public Task<List<UrlResponseDto>> GetAllUrls()
    {
        throw new NotImplementedException();
    }

    public Task<UrlResponseDto> GetOriginalUrl(string shortUrl)
    {
        throw new NotImplementedException();
    }

    public Task<UrlResponseDto> CreateShortUrl(UrlRequestDto urlRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<UrlResponseDto> UpdateShortUrl(UrlRequestDto urlRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<UrlResponseDto> DeleteShortUrl(string shortUrl)
    {
        throw new NotImplementedException();
    }
}