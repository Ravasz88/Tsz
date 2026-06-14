using Microsoft.EntityFrameworkCore;
using TSzKapu.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> User { get; set; }
    public DbSet<SoilData> Soilsensor { get; set; }
}
