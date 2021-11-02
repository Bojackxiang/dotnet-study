using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Study.DTO;

namespace Study.Controllers
{
    [Route("api/base/{username}")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // [start] get all elements ----------------------------
        [HttpGet]
        public IEnumerable<string>  Get()
        {
            var newStringList = new List<string>();
            Console.WriteLine("这里会被 triggered");
            newStringList.Add("hello");
            return newStringList;
        }
        
        // get element by Id 
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            Console.WriteLine(id);
            Console.WriteLine("1234556");
            return Ok("hello");
        }
        
        // template的意思就是，在 route 里面配置的 路由后面接着添加
        [HttpGet("userinfo/{age}")] 
        public IActionResult GetByName(
            [FromRoute] string username,
            [FromRoute] string age) // 对于自己的 route，还能继续 从 route中获取参数
        {
            Console.WriteLine(username + "---" + age);
            Console.WriteLine("1234556");
            return Ok("hello");
        }
        
        // [end] get all elements ----------------------------
        
        // create element by id 
        [HttpPost("{id}")]
        public IActionResult Post(
            [FromRoute] String id, // 这个 名字 和上面的 要一样
            [FromBody] GetElementByIdPostParameters parametersFromBody)
        {   Console.WriteLine(id);

            string values = parametersFromBody.ToString();
            Console.WriteLine(values);

            return CreatedAtAction("GetById", new {id = 1},  "value");
        }
        
        
        // update element by id 
        [HttpPut("{id}")]
        public void Post(int id, [FromBody] string value)
        {
        }
        
        // delete element by id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}