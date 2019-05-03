using System;

namespace SOS.Infrastructure.Model
{
    public class Lesson : Entity
    {
        public int LessonNumber { get; set; }
        public Course Course { get; set; }
        public Instructor Replacement { get; set; }
    }
}