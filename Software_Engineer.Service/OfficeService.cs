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
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepository _officeRepository;
      public OfficeService(IOfficeRepository officeRepository)
        {
            _officeRepository = officeRepository;
        }

        public ActionResult Delete(int id)
        {
           var result= _officeRepository.Delete(id);
            return result;
        }

        public IEnumerable<Office> Get()
        {
            return _officeRepository.Get();
        }

        public ActionResult<Office> Get(int id)
        {
            return _officeRepository.Get(id);   
        }

        public void Post([FromBody] Office office)
        {
            _officeRepository.Post(office);
        }

        public ActionResult Put(int id, [FromBody] Office office1)
        {
            return _officeRepository.Put(id, office1);  
        }
    }
}
