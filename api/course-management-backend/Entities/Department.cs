using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Entities
{
    /// <summary>
    /// This is the entity of department: matches with table 'Department' in DB
    /// </summary>
    [Table("Department")]
    public class Department
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
