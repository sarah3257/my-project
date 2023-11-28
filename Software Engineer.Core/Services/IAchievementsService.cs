using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_Engineer.Core.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Software_Engineer.Core.Services
{
    public interface IAchievementsService
    {
        List<Achievements> Get();
        ActionResult<Achievements> GetById(int id);
        void Post([FromBody] Achievements achievement);
        void Put(int id, [FromBody] Achievements achievement);
        ActionResult Delete(int id);
    }
}
