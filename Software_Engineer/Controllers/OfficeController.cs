using Microsoft.AspNetCore.Mvc;
using Software_Engineer.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly DataContext _context;
        public OfficeController(DataContext context)
        {
            _context = context;
        }


        // GET: api/<OfficeController>
        [HttpGet]
        public IEnumerable<Office> Get()
        {
            return _context.Office;
        }

        // GET api/<OfficeController>/5
        [HttpGet("{id}")]
        public ActionResult<Office> Get(int id)
        {
            var office2= _context.Office.Find(office2 => office2._idOffice == id);
            if(office2 == null)
                return NotFound();
            return office2;
        }

        // POST api/<OfficeController>
        [HttpPost]
        public void Post([FromBody] Office office)
        {
            _context.Office.Add(new Office {_idOffice=_context.countO++,_nameOffice=office._nameOffice });
        }

        // PUT api/<OfficeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Office office1)
        {
            var office2= _context.Office.Find(x=>x._idOffice==id);
            if (office2 == null)
                return NotFound();
            office2._nameOffice=office1._nameOffice;
            return Ok();

        }

        // DELETE api/<OfficeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var office2= _context.Office.Find(office2=>office2._idOffice==id);
            if (office2 == null)
                return NotFound();
            _context.Office.Remove(office2);
            return Ok();

        }
    }
}
