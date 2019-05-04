using System.Collections.Generic;

namespace SOS.Infrastructure.Model
{
    public class Student : User
    {
        public float ToPay { get; set; }
        public float Payments { get; set; }
        public List<Course> Courses { get; set; }
    }
}