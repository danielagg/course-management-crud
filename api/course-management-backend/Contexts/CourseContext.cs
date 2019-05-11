using course_management_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Contexts
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedUsersTable(modelBuilder);
            SeedDepartmentsTable(modelBuilder);
            SeedCoursesTable(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedUsersTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.Parse("16dc743a-727a-4f2f-bb1e-d500f949ca8d"),
                    FirstName = "Brian",
                    LastName = "Smith"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Anthony",
                    LastName = "Grayer"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jean",
                    LastName = "Ashford"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Michelle",
                    LastName = "Reed"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Dave",
                    LastName = "Cuellar"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Frances",
                    LastName = "Bouie"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Howard",
                    LastName = "Clay"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jennifer",
                    LastName = "Spahr"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Patrick",
                    LastName = "Smith"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Haas"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ethel",
                    LastName = "Stebbins"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Henry",
                    LastName = "Arredondo"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Roseann",
                    LastName = "Hammel"
                });
        }

        private void SeedDepartmentsTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = Guid.Parse("7c9d3333-5cc0-43f5-aa21-728866a2ee27"),
                    Name = "Comparative and Institutional Economics"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Macroeconomics"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Microeconomics"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Labour Economis"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Finance"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Mathematics"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Statistics"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Economic Policy"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    Name = "Mathematical Economics and Economic Analysis"
                }
            );
        }

        private void SeedCoursesTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = Guid.NewGuid(),
                    Name = "Course 1",
                    AvailableOnTerm = Course.Term.Fall,
                    Credits = 5,
                    NumberOfLecturesPerTerm = 12,
                    NumberOfSeminarsPerTerm = 12,
                    TypeOfExam = Course.ExamType.WrittenExam,
                    ResponsibleId = Guid.Parse("16dc743a-727a-4f2f-bb1e-d500f949ca8d"),
                    DepartmentId = Guid.Parse("7c9d3333-5cc0-43f5-aa21-728866a2ee27"),
                    Description = "Lorem ipsum of desc",
                    RequirementsFromStudents = "Lorem ipsum of requirements"
                });
        }
    }
}
