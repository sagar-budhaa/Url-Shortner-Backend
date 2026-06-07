using Url_Shortner_Backend.Data;
using Url_Shortner_Backend.DTOs.Url;

namespace Url_Shortner_Backend.Service.Url;

public class UrlService(AppDbContext context) : IUrlService
{
    public Task<List<UrlResponseDto>> GetAllUrls()
    {
        var urls = context.Urls.ToList();
        var urlResponseDtos = urls.Select(
            url => new UrlResponseDto()
            {
                OriginalUrl = url.OriginalUrl,
                ShortUrl = url.ShortUrl,
                IsSuccess = true,
                CreatedAt = url.CreatedAt,
                UpdatedAt = url.UpdatedAt,
            }).ToList();
        return Task.FromResult(urlResponseDtos);
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