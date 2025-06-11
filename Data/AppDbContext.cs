using Microsoft.EntityFrameworkCore;
using XpenseTracker.Models;

namespace XpenseTracker.Data;

public class AppDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xpense.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }

}
