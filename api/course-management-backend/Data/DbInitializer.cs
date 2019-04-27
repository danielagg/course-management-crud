using course_management_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CourseContext context)
        {
            context.Database.EnsureCreated();

            if (context.Courses.Any())
                return;   // DB has been seeded

            var courses = new Course[]
            {
                new Course{ Name = "Chemistry" },
                new Course{ Name = "Microeconomics" },
                new Course{ Name = "Macroeconomics" },
                new Course{ Name = "Calculus" },
                new Course{ Name = "Trigonometry" },
                new Course{ Name = "Composition" },
                new Course{ Name = "Literature" }
            };

            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }

            context.SaveChanges();
        }
    }
}
