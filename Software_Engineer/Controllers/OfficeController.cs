using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private static List<Office>_Office=new List<Office>();
        private static int count=0;
        // GET: api/<OfficeController>
        [HttpGet]
        public IEnumerable<Office> Get()
        {
            return _Office;
        }

        // GET api/<OfficeController>/5
        [HttpGet("{id}")]
        public Office Get(int id)
        {
            var office2= _Office.Find(office2 => office2._idOffice == id);
            return office2;
        }

        // POST api/<OfficeController>
        [HttpPost]
        public void Post([FromBody] Office office)
        {
            _Office.Add(new Office {_idOffice=count++,_nameOffice=office._nameOffice });
        }

        // PUT api/<OfficeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Office office1)
        {
            var office2=_Office.Find(office1=>office1._idOffice==id);
            office2._nameOffice=office1._nameOffice;

        }

        // DELETE api/<OfficeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var office2=_Office.Find(office2=>office2._idOffice==id);
            _Office.Remove(office2);
        }
    }
}
