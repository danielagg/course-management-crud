using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Models
{
    /// <summary>
    /// This is the model we return to the caller once its tries to access a course or courses
    /// </summary>
    public class CourseModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Credits { get; set; }

        public string ResponsibleUserName { get; set; }
    }
}
