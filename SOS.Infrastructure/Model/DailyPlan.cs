using System;
using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class DailyPlan : Entity
    {
        public DateTime Day { get; set; }
        public List<ClassroomDailyPlan> ClassroomsDailyPlan { get; set; }
    }
}