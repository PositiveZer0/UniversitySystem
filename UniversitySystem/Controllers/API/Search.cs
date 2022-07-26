// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversitySystem.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class Search : ControllerBase
    {
        // GET: api/<Search>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Search>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Search>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Search>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Search>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
