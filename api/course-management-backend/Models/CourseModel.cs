using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Models
{
    public class CourseModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Credits { get; set; }

        public string ResponsibleUserName { get; set; }
    }
}
