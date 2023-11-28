using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.Services
{
    public interface IOfficeService
    {
        IEnumerable<Office> Get();


        ActionResult<Office> Get(int id);


        void Post([FromBody] Office office);


        ActionResult Put(int id, [FromBody] Office office1);



        ActionResult Delete(int id);
    }
}
