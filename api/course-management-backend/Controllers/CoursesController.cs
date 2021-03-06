﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using course_management_backend.Contexts;
using course_management_backend.Entities;
using course_management_backend.Repositories;
using course_management_backend.Filters;
using course_management_backend.Models;
using AutoMapper;

namespace course_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _repo;
        private readonly IMapper _mapper;

        public CoursesController(ICourseRepository repo, IMapper mapper)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/Courses
        [HttpGet]
        [MultipleCoursesResultFilter]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            var courseEntities = await _repo.GetCoursesAsync();
            return Ok(courseEntities);
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        [CourseResultFilter]
        public async Task<ActionResult<Course>> GetCourse(Guid id)
        {
            var course = await _repo.GetCourseAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        // PUT: api/Courses/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCourse(int id, Course course)
        //{
        //    if (id != course.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(course).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CourseExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Courses
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(CourseAtCreation courseToInsert)
        {
            var courseEntity = _mapper.Map<Course>(courseToInsert);

            _repo.AddCourse(courseEntity);

            await _repo.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = courseEntity.Id }, courseEntity);
        }

        // DELETE: api/Courses/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Course>> DeleteCourse(int id)
        //{
        //    var course = await _context.Courses.FindAsync(id);
        //    if (course == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Courses.Remove(course);
        //    await _context.SaveChangesAsync();

        //    return course;
        //}

        //private bool CourseExists(int id)
        //{
        //    return false; // _context.Courses.Any(e => e.Id == id);
        //}
    }
}
