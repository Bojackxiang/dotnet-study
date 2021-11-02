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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var newStringList = new List<string>();
            newStringList.Add("hello");
            return newStringList;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /**
         * 【自动匹配】
         * 一个经典的案列，
         * 进来的参数会和我这边的 class CreateCourseParams 自动匹配
         * 【Post Body】
         * * {
         * "CourseName": "math",
         * "StudentsList": [
         * {"StudentName": "Alex"},
         * {"StudentName": "Eric"}
         * ]
         * }
         */
        [HttpPost]
        public IActionResult Post([FromBody] CreateCourseParams value)
        {
            Console.WriteLine(value.CourseName);
            Console.WriteLine("count" + value.StudentsList.Count);
            foreach (var student in value.StudentsList) Console.WriteLine(student.StudentName);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}