using Microsoft.EntityFrameworkCore; 

namespace Day2.Models
{
    public class CoursesCenterContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }  
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CourseResult { get; set; }
        public DbSet<Trainee> Trainees { get; set; }

        public CoursesCenterContext()
            : base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring the precision and scale for Salary
            modelBuilder.Entity<Instructor>()
                .Property(i => i.Salary)
                .HasPrecision(18, 2); // 18 precision and 2 decimal places
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // pass to it connection string 
            optionsBuilder.UseSqlServer(
                // connection string 
                "Data Source =.; Initial Catalog = CoursesCenter; Integrated Security = True; Encrypt=False ;Trust Server Certificate=True"

            );

            // base implementation of this function 
            base.OnConfiguring(optionsBuilder);


        }



    }
}
