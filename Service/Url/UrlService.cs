using Url_Shortner_Backend.Data;
using Url_Shortner_Backend.DTOs.Url;
using Url_Shortner_Backend.Service.lib;

namespace Url_Shortner_Backend.Service.Url;

public class UrlService(AppDbContext context, IShortUrlGenerator uriGenerator) : IUrlService
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

    public async Task<UrlResponseDto> CreateShortUrl(UrlRequestDto urlRequestDto)
    {
        var originalUrl = urlRequestDto.OriginalUrl;
        var shortUrl = uriGenerator.GenerateShortUri();
        var url = new Model.Url
        {
            OriginalUrl = originalUrl,
            ShortUrl = shortUrl
        };
        context.Urls.Add(url);
        await context.SaveChangesAsync();
        return new UrlResponseDto
        {
            OriginalUrl = originalUrl,
            ShortUrl = shortUrl,
            IsSuccess = true,
            CreatedAt = url.CreatedAt,
            UpdatedAt = url.UpdatedAt,
        };
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