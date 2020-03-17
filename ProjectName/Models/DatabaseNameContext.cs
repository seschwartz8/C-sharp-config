using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class DatabaseNameContext : DbContext
  {
    public DbSet<TableName> TableNames { get; set; }

    public DatabaseNameContext(DbContextOptions options) : base(options) { }
  }
}