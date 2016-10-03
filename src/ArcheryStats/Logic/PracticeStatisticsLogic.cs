using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArcheryStats.Models;
using ArcheryStats.IRepository;

namespace ArcheryStats.Logic
{
    public class PracticeStatisticsLogic : IPracticeStatisticsLogic
    {
        private readonly IPracticeStatisticsRepository _practiceStatisticsRepository;

        public PracticeStatisticsLogic(IPracticeStatisticsRepository practiceStatisticsRepository)
        {
            _practiceStatisticsRepository = practiceStatisticsRepository;
        }

        public void Delete(int id)
        {
            _practiceStatisticsRepository.Delete(id);
        }

        public PracticeStatistics Get(int id)
        {
            return _practiceStatisticsRepository.FindById(id);
        }

        public IQueryable<PracticeStatistics> GetList()
        {
            var practiceStats = _practiceStatisticsRepository.All();

            if (practiceStats == null || !practiceStats.Any()) {
                return Enumerable.Empty<PracticeStatistics>().AsQueryable();
            }
            return practiceStats;
        }

        public void Save(PracticeStatistics practiceStatistics)
        {
            _practiceStatisticsRepository.Insert(practiceStatistics);
        }
    }
}
