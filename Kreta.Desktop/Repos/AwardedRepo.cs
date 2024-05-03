using Kreta.Desktop.Database;
using MenuProject.Models.Scholarship;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class AwardedRepo
    {
        public List<AwardedStudent> FindAll()
        {
            return KretaDatabase.AwardedStudents;
        }

        public int GetNumberOfAwardedStudent()
        {
            return 0;
        }
    }
}
