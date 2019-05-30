using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class StudentCourse : Entity
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}