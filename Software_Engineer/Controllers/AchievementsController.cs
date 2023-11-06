using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementsController : ControllerBase
    {
        private static List<Achievements>_Achievements=new List<Achievements>();
        private static int _count=0;
        // GET: api/<AchievementsController>
        [HttpGet]
        public IEnumerable<Achievements> Get()
        {
            return _Achievements;
        }

        // GET api/<AchievementsController>/5
        [HttpGet("{id}")]
        public Achievements Get(int id)
        {
            return _Achievements.Find(a => a._idAchievement == id); ;
        } 

        // POST api/<AchievementsController>
        [HttpPost]
        public void Post([FromBody] Achievements achievement)
        {
            _Achievements.Add(new Achievements { _idAchievement=_count++,_nameAchievement=achievement._nameAchievement});
            
        }

        // PUT api/<AchievementsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Achievements achievement)
        {
            var ach=_Achievements.Find(achievement=>achievement._idAchievement==id);
            ach._nameAchievement = achievement._nameAchievement;
        }

        // DELETE api/<AchievementsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ach=_Achievements.Find(a=>a._idAchievement==id);
            _Achievements.Remove(ach);
        }
    }
}
