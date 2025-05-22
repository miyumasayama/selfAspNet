using Microsoft.EntityFrameworkCore;

namespace SelfAspNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        // DbSet 定義（例）
        public DbSet<User> Users { get; set; }
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}