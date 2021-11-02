using System.ComponentModel.DataAnnotations;
using Study.DTO;
using Study.Models;

namespace Study.Validations
{
    public class CreateCourseValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {   
            // 获取到 要验证的对象，这个情况下，就是我们 传捡来的参数 CreateCourseParams 
            var course = (CreateCourseParams)validationContext.ObjectInstance;

            // 对于course 里面的要求
            if (course.StudentsList.Count <= 0)
            {
                return new ValidationResult("课堂学生的长度必须超过 1！");
            }

            return ValidationResult.Success;
        }
    }
}