using Kreta.Desktop.Repos;
using MenuProject.Repos;

namespace Kreta.Desktop.Service
{
    public class ScholarshipService
    {
        private StudentRepo _studentRepo;
        private AwardedRepo _awardedRepo;

        public ScholarshipService() 
        {
            _studentRepo = new StudentRepo();
            _awardedRepo = new AwardedRepo();
        }
    }
}
