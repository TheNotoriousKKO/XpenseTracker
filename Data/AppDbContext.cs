using Microsoft.EntityFrameworkCore;
using XpenseTracker.Models;

namespace XpenseTracker.Data;

public class AppDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=xpense.db");
    }
}
