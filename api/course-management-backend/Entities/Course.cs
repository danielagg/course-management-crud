using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Entities
{
    /// <summary>
    /// This is the entity of course: matches with table 'Course' in DB
    /// </summary>
    [Table("Course")]
    public class Course
    {
        public enum Term
        {
            Spring,
            Fall,
            Both
        }

        public enum ExamType
        {
            WrittenExam,
            OralExam,
            WrittenAndOralExam,
            Project,
            PracticalMark,
            OfferedMark,
            Signature
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Credits { get; set; }

        [Range(0, 100)]
        public int? NumberOfLecturesPerTerm { get; set; }

        [Range(0, 100)]
        public int? NumberOfSeminarsPerTerm { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public Term AvailableOnTerm { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(1000)]
        public string RequirementsFromStudents { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public ExamType TypeOfExam { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required]
        public Guid ResponsibleId { get; set; }

        public User Responsible { get; set; }
    }
}
