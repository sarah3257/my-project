using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using Software_Engineer.Core.Services;
using Software_Engineer.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectsService _projectsService;
        public ProjectsController(IProjectsService projectsService)
        {
           _projectsService  = projectsService;
        }


        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<Projects> Get()
        {
           return _projectsService.Get();
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public ActionResult<Projects> Get(int id)
        {
         return _projectsService.Get(id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] Projects project)
        {
            _projectsService.Post(project);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Projects project)
        {
            return  _projectsService.Put(id, project);  
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            return _projectsService.Delete(id);


        }
    }
}
