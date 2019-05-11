using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Models
{
    /// <summary>
    /// This is the model we expect from the caller when attempting to insert a new course
    /// </summary>
    public class CourseAtCreation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ResponsibleUserId { get; set; }
    }
}
