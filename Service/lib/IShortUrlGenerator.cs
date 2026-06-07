namespace Url_Shortner_Backend.Service.lib;

public interface IShortUrlGenerator
{
    public string GenerateShortUri(int length = 6);

}