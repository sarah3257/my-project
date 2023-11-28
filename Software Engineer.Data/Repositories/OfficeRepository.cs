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
    public class OfficeRepository : IOfficeRepository
    {
        private readonly DataContext _context;
        public OfficeRepository(DataContext context)
        {
            _context = context;
        }
        public ActionResult Delete(int id)
        {
            var office2 = _context.Office.Find(office2 => office2._idOffice == id);
            if (office2 == null)
                return new NotFoundResult();
            _context.Office.Remove(office2);
            return new  OkResult();
        }

        public IEnumerable<Office> Get()
        {
            return _context.Office;
        }

        public ActionResult<Office> Get(int id)
        {
            var office2 = _context.Office.Find(office2 => office2._idOffice == id);
            if (office2 == null)
                return new NotFoundResult();
            return office2;
        }

        public void Post([FromBody] Office office)
        {
            _context.Office.Add(new Office { _idOffice = _context.countO++, _nameOffice = office._nameOffice });
        }

        public ActionResult Put(int id, [FromBody] Office office1)
        {
            var office2 = _context.Office.Find(x => x._idOffice == id);
            if (office2 == null)
                return new NotFoundResult();
            office2._nameOffice = office1._nameOffice;
            return new OkResult();
        }



        
    }
}
