using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _Context;
        public ProjectsController(DataContext context)
        {
            _Context = context;
        }


        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<Projects> Get()
        {
            return _Context.Projects;
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public ActionResult<Projects> Get(int id)
        {
          var project= _Context.Projects.Find(project => project.IdProject == id);
            if (project == null)
                return NotFound();
            return project;
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] Projects project)
        {
            _Context.Projects.Add(new Projects { IdProject =_Context.countP++, NameProject =project.NameProject, CreationDate=project.CreationDate});
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Projects project)
        {
            var project2= _Context.Projects.Find(project=>project.IdProject == id);
            if (project2 == null)
                return NotFound();
            project2.NameProject=project.NameProject;
            project2.CreationDate=project.CreationDate;
            return Ok();
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            var project2= _Context.Projects.Find(project=>project.IdProject == id);
            if (project2 == null)
                return NotFound();
            _Context.Projects.Remove(project2);
            return Ok();

        }
    }
}
