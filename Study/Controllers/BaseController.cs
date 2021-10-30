using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Study.Controllers
{
    [Route("api/base")]
    [ApiController]
    public class BaseController : ControllerBase
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

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Post(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}