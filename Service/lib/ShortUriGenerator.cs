namespace Url_Shortner_Backend.Service.lib;

public class ShortUriGenerator
{
    private const string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_";
    private static readonly Random Random = new();

    public static string GenerateShortUri(int length = 6)
    {
        var shortUri = new char[length];
        for (var i = 0; i < length; i++)
        {
            shortUri[i] = AllowedChars[Random.Next(AllowedChars.Length)];
        }
        return new string(shortUri);
    }
}