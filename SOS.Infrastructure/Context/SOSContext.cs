using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
        public DbSet<StudentCourse> StudentsCourses { get; set; }        
        public DbSet<User> User { get; set; }
        public DbSet<WeeklyPlan> WeeklyPlan { get; set; }
        public DbSet<YearlyPlan> YearlyPlan { get; set; }

        public SOSContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<SOSContext>(options => options.UseMySQL("DataSource=dbo.SOSApi.db", builder => builder.MigrationsAssembly("SOS.Infrastructure")));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasMany<Course>().
        }

    }
}