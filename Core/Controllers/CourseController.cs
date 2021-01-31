using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Model;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = new List<Course>()
            {
                new Course() {Id = 1, Name = "Course 1"},
                new Course() {Id = 2, Name = "Course 2"},
                new Course() {Id = 3, Name = "Course 3"},
                new Course() {Id = 4, Name = "Course 4"}
            };

            return Ok(courses);
        }

    }
}
