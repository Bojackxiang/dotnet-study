using System.Collections.Generic;
using Study.Models;

namespace Study.DTO
{
    public class CreateCourseParams
    {
        public string CourseName { get; set; }
        public IList<Student> StudentsList { get; set; } = new List<Student>();
    }
}