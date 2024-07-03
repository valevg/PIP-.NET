using Microsoft.EntityFrameworkCore;
using PROGINETPRIL.Models;

namespace PROGINETPRIL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Specialties> Specialties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Groups> Groups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Конфигурация таблицы "Users"
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);
            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .IsRequired();

            // Конфигурация таблицы "Roles"
            modelBuilder.Entity<Role>()
                .HasKey(r => r.RoleId);
            modelBuilder.Entity<Role>()
                .Property(r => r.RoleName)
                .IsRequired();
            // Конфигурация других таблиц
            modelBuilder.Entity<Specialties>()
                .HasKey(s => s.SpecialtyId);
            modelBuilder.Entity<Course>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Teachers>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Students>()
                .HasKey(s => s.StudentId);
            modelBuilder.Entity<Groups>()
                .HasKey(g => g.GroupId);




            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Teacher)
                .WithMany(t => t.TeacherCourses)
                .HasForeignKey(tc => tc.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(tc => tc.Course)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(tc => tc.CourseId);

            modelBuilder.Entity<Students>()
                .HasOne(s => s.Groups)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<Students>()
        .HasOne(s => s.User)
        .WithOne(u => u.Students)
        .HasForeignKey<Students>(s => s.UserId);
            modelBuilder.Entity<Teachers>()
        .HasOne(t => t.User)
        .WithOne(u => u.Teachers)
        .HasForeignKey<Teachers>(t => t.UserId);
            modelBuilder.Entity<Employee>()
        .HasOne(t => t.User)
        .WithOne(u => u.Employee)
        .HasForeignKey<Employee>(t => t.UserId);
        }

    }
    }
