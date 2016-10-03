using ArcheryStats.Models;
using System.Linq;

namespace ArcheryStats.Logic
{
    public interface IPracticeStatisticsLogic
    {
        PracticeStatistics Get(int id);
        IQueryable<PracticeStatistics> GetList();
        void Save(PracticeStatistics practiceStatistics);
        void Delete(int id);
    }
}
