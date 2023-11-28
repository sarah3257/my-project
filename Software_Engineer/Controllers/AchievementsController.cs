using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using Software_Engineer.Core.Services;
using Software_Engineer.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private readonly IAchievementsService _AchievementsService;

       public AchievementsController(IAchievementsService achievementsService)
        {
            _AchievementsService = achievementsService;
        }

        // GET: api/<AchievementsController>
        [HttpGet]
        public IEnumerable<Achievements> Get()
        {
            return _AchievementsService.Get();
        }

        // GET api/<AchievementsController>/5
        [HttpGet("{id}")]
        public ActionResult <Achievements> Get(int id)
        {
       return _AchievementsService.GetById(id);
        } 

        // POST api/<AchievementsController>
        [HttpPost]
        public void Post([FromBody] Achievements achievement)
        {
           _AchievementsService.Post(achievement);
        }

        // PUT api/<AchievementsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Achievements achievement)
        {
             _AchievementsService.Put(id, achievement);
        }

        // DELETE api/<AchievementsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           return _AchievementsService.Delete(id);
        }
    }
}
