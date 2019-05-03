using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class School : Entity
    {
        public string Name { get; set; }
        public List<YearlyPlan> Schedule { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Administrator>Administrators { get; set; }
        public List<OfficeWorker>OfficeWorkers { get; set; }
    }
}