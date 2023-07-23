using Microsoft.EntityFrameworkCore;
using StrategyFiles.Domain.Models;

namespace StrategyFiles.Infrastructure.Repositories
{
    public class BinDbContext : DbContext
    {
        public DbSet<ParsedBin> Bins { get; set; }
        public bool TrustServerCertificate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LP51IT4\\SQLEXPRESS;Database=rangebin;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}