using System;
using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class YearlyPlan : Entity
    {
        public DateTime Year { get; set; }
        public List<WeeklyPlan>WeeklyPlans { get; set; }
    }
}