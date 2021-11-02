using System.Collections;
using System.Collections.Generic;

namespace Study.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public ICollection Students { get; set; } = new List<Student>();
    }
}