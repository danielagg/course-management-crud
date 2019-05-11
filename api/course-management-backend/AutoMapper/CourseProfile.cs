using AutoMapper;
using course_management_backend.Entities;
using course_management_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.AutoMapper
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseModel>()
                .ForMember(
                    dst => dst.ResponsibleUserName,
                    opt => opt.MapFrom(src => $"{src.Responsible.FirstName} {src.Responsible.LastName}"));

            CreateMap<CourseAtCreation, Course>();
        }
    }
}
