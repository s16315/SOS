using Microsoft.EntityFrameworkCore;
using SOS.Infrastructure.Model;

namespace SOS.Infrastructure.Context
{
    public class SOSContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Classroom> Classroom{ get; set; }
        public DbSet<ClassroomDailyPlan> ClassroomDailyPlan { get; set; }
        public DbSet<Course> Course{ get; set; }
        public DbSet<DailyPlan> DailyPlan { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<OfficeWorker> OfficeWorker { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<WeeklyPlan> WeeklyPlan { get; set; }
        public DbSet<YearlyPlan> YearlyPlan { get; set; }
        
        public SOSContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=31.179.186.242;user id=PJATK;password=ADS1234eerwrw;port=59590;database=SOS;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}