using ArcheryStats.Models;
using Microsoft.EntityFrameworkCore;

namespace ArcheryStats
{
    public class ArcheryStatsContext : DbContext
    {
        public ArcheryStatsContext(DbContextOptions<ArcheryStatsContext> options) : base(options)
        {
        }

        public DbSet<PracticeStatistics> PracticeStatistics { get; set; }
    }
}
