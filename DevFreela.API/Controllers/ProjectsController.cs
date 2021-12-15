using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query) { return Ok(); }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) { return Ok(); }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel model)
        {
            if (model.Title.Length > 50) return BadRequest();

            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel model)
        {
            if (model.Description.Length > 200) return BadRequest();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
