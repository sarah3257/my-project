using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Repositories;
using Software_Engineer.Core.Services;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Service
{
    public class AchievementsService : IAchievementsService
    {
        private readonly IAchievementsRepository _achievementsRepository;

        public AchievementsService(IAchievementsRepository achievementsRepository)
        {
            _achievementsRepository = achievementsRepository;
        }

     

        public List<Achievements> Get()
        {
            return _achievementsRepository.Get();
        }

        public ActionResult<Achievements> GetById(int id)
        {
            return _achievementsRepository.GetById(id);
        }

        public void Post([FromBody] Achievements achievement)
        {
            _achievementsRepository.Post(achievement);
        }

        public void Put(int id, [FromBody] Achievements achievement)
        {
            _achievementsRepository.Put(id, achievement);
        }
        public ActionResult Delete(int id)
        {
            var result = _achievementsRepository.Delete(id);    
            return result;
        }
    }
}
