using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }

    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public SweetAndSavoryContext(DbContextOptions options) : base(options) { } 
  }
}