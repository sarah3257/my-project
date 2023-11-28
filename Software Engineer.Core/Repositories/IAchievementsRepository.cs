using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Repositories
{
    public  interface IAchievementsRepository
    {
        List<Achievements> Get();

        ActionResult<Achievements> GetById(int id);
        void Post([FromBody] Achievements achievement);
        ActionResult Put(int id, [FromBody] Achievements achievement);
        ActionResult Delete(int id);        
      
    }
}
