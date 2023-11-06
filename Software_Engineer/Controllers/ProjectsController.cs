using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private static List<Projects> _Projects = new List<Projects> { new Projects { IdProject = 1, NameProject = "police", CreationDate = new DateTime(2021, 08,01)},
            new Projects{IdProject = 2, NameProject = "למטייל", CreationDate = new DateTime(2022, 11, 01)} };
        private static int _count = 2;
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<Projects> Get()
        {
            return _Projects;
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public Projects Get(int id)
        {
            return _Projects.Find(project => project.IdProject == id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] Projects project)
        {
            _Projects.Add(new Projects { IdProject =_count++, NameProject =project.NameProject, CreationDate=project.CreationDate});
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Projects project)
        {
            var project2= _Projects.Find(project=>project.IdProject == id);
            
            project2.NameProject=project.NameProject;
            project2.CreationDate=project.CreationDate;

        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var project2=_Projects.Find(project=>project.IdProject == id);
            _Projects.Remove(project2);
        }
    }
}
