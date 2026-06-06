using Microsoft.EntityFrameworkCore;

namespace Url_Shortner_Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options ) : DbContext(options)
{
    
    
}