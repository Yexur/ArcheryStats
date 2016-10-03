using ArcheryStats.Core;
using ArcheryStats.IRepository;
using ArcheryStats.Models;

namespace ArcheryStats.Repository
{
    public class PracticeStatisticsRepository : Repository<PracticeStatistics>, IPracticeStatisticsRepository
    {
        public PracticeStatisticsRepository(ArcheryStatsContext context) : base(context)
        {
        }
    }
}
