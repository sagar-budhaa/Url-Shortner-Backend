using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Url_Shortner_Backend.Model;

[Index(nameof(ShortUrl), IsUnique = true)]
public class Url
{
    [Key] public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public string OriginalUrl { get; set; }
    [Required]
    public string ShortUrl { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    [Required]
    public DateTime UpdatedAt { get; set; }
    
    public bool IsActive { get; set; }  = true;
}