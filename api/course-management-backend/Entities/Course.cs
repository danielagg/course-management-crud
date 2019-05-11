﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Entities
{
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

        public Term? AvailableOnTerm { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(1000)]
        public string RequirementsFromStudents { get; set; }

        [Required]
        public ExamType TypeOfExam { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

        [Required]
        public Guid ResponsibleId { get; set; }

        public User Responsible { get; set; }
    }
}