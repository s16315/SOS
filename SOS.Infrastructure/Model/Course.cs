using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class Course : Entity
    {
        public string Name { get; set; }
        public Instructor Instructor { get; set; }
        public int MaxStudents { get; set; }
        public float Cost { get; set; }
        public Language Language { get; set; }
    }
}