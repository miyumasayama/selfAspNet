using Microsoft.EntityFrameworkCore;

namespace SelfAspNet.Models;

// ContextはDBとEntityをつなぐ役割を持つ
public class MyContext : DbContext
{
  public MyContext(DbContextOptions<MyContext> options) : base(options) { }

  public DbSet<Book> Books { get; set; } = null!;
}