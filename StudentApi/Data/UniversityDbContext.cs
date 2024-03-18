using Microsoft.EntityFrameworkCore;
using StudentApi.Model;

namespace StudentApi.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Teaching> Teachings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => e.EnrollmentID);

            /*
            
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentID);
            
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseID);*/

            modelBuilder.Entity<Teaching>()
                .HasKey(t => t.TeachingID);
            /*
            modelBuilder.Entity<Teaching>()
                .HasOne(t => t.Instructor)
                .WithMany(i => i.Teachings)
                .HasForeignKey(t => t.InstructorID);
            
            modelBuilder.Entity<Teaching>()
                .HasOne(t => t.Course)
                .WithMany(c => c.Teachings)
                .HasForeignKey(t => t.CourseID);*/
        }
    }
}
