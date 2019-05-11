using course_management_backend.Entities;
using course_management_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();

        Task<Course> GetCourseAsync(Guid id);

        void AddCourse(Course course);

        Task<bool> SaveChangesAsync();
    }
}
