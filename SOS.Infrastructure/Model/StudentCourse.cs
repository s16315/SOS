using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class StudentCourse : Entity
    {
        public long StudentId { get; set; }
        public List<Student>Student{ get; set; }
        public long CourseId { get; set; }
        public List<Course>Course { get; set; }
    }
}