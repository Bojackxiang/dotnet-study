using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Study.DTO;

namespace Study.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CreateCourseParams value)
        {
            Console.WriteLine(value.CourseName);
            Console.WriteLine("count" + value.StudentsList.Count);
            foreach (var student in value.StudentsList) Console.WriteLine(student.StudentName);
            return Ok();
        }
        
    }
}