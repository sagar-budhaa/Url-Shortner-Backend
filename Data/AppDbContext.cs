using Microsoft.EntityFrameworkCore;
using Url_Shortner_Backend.Model;

namespace Url_Shortner_Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options ) : DbContext(options)
{
    public DbSet<Url> Urls { get; set; }
    public DbSet<Click> Clicks { get; set; }
    
}