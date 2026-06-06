namespace Url_Shortner_Backend.DTOs.GlobalErrorHandler;

public class ExceptionResponseHandlerDto
{
    public int Status { get; set; }
    public string Title { get; set; }
    public string Detail { get; set; }
}