using System;
using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class ClassroomDailyPlan : Entity
    {
        public Classroom Classroom { get; set; }
        public List<Lesson> haur08 { get; set; }
        public List<Lesson> haur09 { get; set; }
        public List<Lesson> haur10 { get; set; }
        public List<Lesson> haur11 { get; set; }
        public List<Lesson> haur12 { get; set; }
        public List<Lesson> haur13 { get; set; }
        public List<Lesson> haur14 { get; set; }
        public List<Lesson> haur15 { get; set; }
        public List<Lesson> haur16 { get; set; }
        public List<Lesson> haur17 { get; set; }
        public List<Lesson> haur18 { get; set; }
        public List<Lesson> haur19 { get; set; }
        public List<Lesson> haur20 { get; set; }
        public List<Lesson> haur21 { get; set; }
    }
}