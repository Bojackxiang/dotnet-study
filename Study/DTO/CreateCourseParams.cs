using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Study.Models;
using Study.Validations;

namespace Study.DTO
{
    [CreateCourseValidation]
    public class CreateCourseParams // : IValidatableObject
    {
        [Required(ErrorMessage = "不能为空")]
        [MaxLength(4, ErrorMessage = "课程名称长度不能超过4")]
        public string CourseName { get; set; }

        public IList<Student> StudentsList { get; set; } = new List<Student>();

        /*
         * 对多个 parameters 之间的关系做 补充验证
         */
        // {
        //     "CourseName": "maths",
        //     "StudentsList": [
        //     {"StudentName": "Alex"},
        //     {"StudentName": "Eric"}
        //     ]
        // }
        // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        // {
        //     if (StudentsList.Count == 0)
        //         yield return new ValidationResult(
        //             "课程必须有学生", // 自定义错误信息
        //             new[] {"StudentsList"}); // 那个地方出错
        //     // 【思考🤔】对于 yield 的思考
        //     // 如果不加 这个 yield 这个 validation 就会一直往下跑，但实际上我们已经不需要他继续了
        // }
    }
}