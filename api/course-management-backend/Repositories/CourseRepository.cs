using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_management_backend.Contexts;
using course_management_backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace course_management_backend.Repositories
{
    public class CourseRepository : ICourseRepository, IDisposable
    {
        private CourseContext _context;

        public CourseRepository(CourseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Course> GetCourseAsync(Guid id)
        {
            return await _context.Courses
                .Include(c => c.Department)
                .Include(c => c.Responsible)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _context.Courses
                .Include(c => c.Department)
                .Include(c => c.Responsible)
                .ToListAsync();
        }

        #region dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        #endregion
    }
}
