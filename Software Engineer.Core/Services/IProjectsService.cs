using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Services
{
    public interface IProjectsService
    {
        IEnumerable<Projects> Get();


        ActionResult<Projects> Get(int id);


        void Post([FromBody] Projects project);



        ActionResult Put(int id, [FromBody] Projects project);


        ActionResult Delete(int id);
    }
}
