using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Repositories;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Data.Repositories
{
    public class AchievementsRepository : IAchievementsRepository
    {
        private readonly DataContext _context;
        public AchievementsRepository(DataContext context)
        {
            _context = context;
        }

        public ActionResult Delete(int id)
        {
            var ach = _context.Achievements.Find(a => a._idAchievement == id);
            if (ach == null)
                return new NotFoundResult();
            _context.Achievements.Remove(ach);
            return new OkResult();
        }

        public List<Achievements> Get()
        {
            return _context.Achievements;
        }

        public ActionResult<Achievements> GetById(int id)
        {
            var ach = _context.Achievements.Find(a => a._idAchievement == id);
            if (ach == null)
            {
                return new NotFoundResult();
            }
            return ach;
        }

        public void Post([FromBody] Achievements achievement)
        {
            _context.Achievements.Add(new Achievements
            {
                _idAchievement = _context.countA++,
                _nameAchievement = achievement._nameAchievement
            });
        }

        public ActionResult Put(int id, [FromBody] Achievements achievement)
        {
            var ach = _context.Achievements.Find(achievement => achievement._idAchievement == id);
            if (ach == null)
                return new NotFoundResult();
            ach._nameAchievement = achievement._nameAchievement;
            return new OkResult();
        }
    }
}
