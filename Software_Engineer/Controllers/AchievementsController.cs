using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private readonly DataContext _context;
        
       public AchievementsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<AchievementsController>
        [HttpGet]
        public IEnumerable<Achievements> Get()
        {
            return _context.Achievements;
        }

        // GET api/<AchievementsController>/5
        [HttpGet("{id}")]
        public ActionResult <Achievements> Get(int id)
        {
            var ach = _context.Achievements.Find(a => a._idAchievement == id);
            if (ach == null)
                return NotFound();

            return ach;
        } 

        // POST api/<AchievementsController>
        [HttpPost]
        public void Post([FromBody] Achievements achievement)
        {
            _context.Achievements.Add(new Achievements { _idAchievement=_context.countA++,_nameAchievement=achievement._nameAchievement});
            
        }

        // PUT api/<AchievementsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Achievements achievement)
        {
            var ach= _context.Achievements.Find(achievement=>achievement._idAchievement==id);
            if (ach == null)
                return NotFound();
            ach._nameAchievement = achievement._nameAchievement;
            return Ok();
        }

        // DELETE api/<AchievementsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ach= _context.Achievements.Find(a=>a._idAchievement==id);
            if (ach == null)
                return NotFound();
            _context.Achievements.Remove(ach);
            return Ok();
        }
    }
}
