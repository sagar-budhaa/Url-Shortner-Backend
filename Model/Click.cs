using System.ComponentModel.DataAnnotations;

namespace Url_Shortner_Backend.Model;

public class Click
{
    [Key] public Guid ClickId { get; set; } = Guid.NewGuid();
    
    [Required]
    public string IpAddress { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string UserAgent { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    [Required]
    public Guid UrlId { get; set; }
}