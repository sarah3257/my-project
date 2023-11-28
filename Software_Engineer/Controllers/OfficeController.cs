using Microsoft.AspNetCore.Mvc;
//using Software_Engineer.Core.Services;
using Software_Engineer.Core.Entities;
using Software_Engineer.Core.Services;
using Software_Engineer.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Software_Engineer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeService _officeService;
        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }


        // GET: api/<OfficeController>
        [HttpGet]
        public IEnumerable<Office> Get()
        {
            return _officeService.Get();    
        }

        // GET api/<OfficeController>/5
        [HttpGet("{id}")]
        public ActionResult<Office> Get(int id)
        {        
            return _officeService.Get(id);
        }

        // POST api/<OfficeController>
        [HttpPost]
        public void Post([FromBody] Office office)
        {
            _officeService.Post(office);
        }

        // PUT api/<OfficeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Office office1)
        {
            _officeService.Put(id, office1);    
        }

        // DELETE api/<OfficeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           return _officeService.Delete(id);    

        }
    }
}
