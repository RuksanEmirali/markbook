using Markbook.Models;
using Microsoft.EntityFrameworkCore;

namespace Markbook;

public class MarkbookContext : DbContext
{
    public MarkbookContext(DbContextOptions<MarkbookContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }
}