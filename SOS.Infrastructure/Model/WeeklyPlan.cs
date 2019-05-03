using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class WeeklyPlan : Entity
    {
        public int weekInYearNumber { get; set; }
        public List<DailyPlan>DailyPlans { get; set; }
    }
}