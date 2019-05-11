using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static course_management_backend.Entities.Course;

namespace course_management_backend.Entities.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
                .Property(b => b.AvailableOnTerm)
                .HasConversion(
                    b => b.ToString(),
                    b => Enum.Parse<Term>(b));

            builder
                .Property(b => b.TypeOfExam)
                .HasConversion(
                    b => b.ToString(),
                    b => Enum.Parse<ExamType>(b));
        }
    }
}
