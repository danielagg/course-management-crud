using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Entities.Course>> GetCoursesAsync();

        Task<Entities.Course> GetCourseAsync(Guid id);
    }
}
