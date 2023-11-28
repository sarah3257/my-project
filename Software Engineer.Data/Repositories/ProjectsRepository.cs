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
    public class ProjectsRepository : IProjectsRepository
    {
        private readonly DataContext _context;
        public ProjectsRepository(DataContext context)
        {
            _context = context;
        }
        public ActionResult Delete(int id)
        {

            var project2 = _context.Projects.Find(project => project.IdProject == id);
            if (project2 == null)
                return  new NotFoundResult();
            _context.Projects.Remove(project2);
            return new OkResult();
        }

        public IEnumerable<Projects> Get()
        {
            return _context.Projects;
        }

        public ActionResult<Projects> Get(int id)
        {
            var project = _context.Projects.Find(project => project.IdProject == id);
            if (project == null)
                return new NotFoundResult();
            return project;
        }

        public void Post([FromBody] Projects project)
        {
            _context.Projects.Add(new Projects { IdProject = _context.countP++, NameProject = project.NameProject, CreationDate = project.CreationDate });
        }

        public ActionResult Put(int id, [FromBody] Projects project)
        {
            var project2 = _context.Projects.Find(project => project.IdProject == id);
            if (project2 == null)
                return new NotFoundResult();
            project2.NameProject = project.NameProject;
            project2.CreationDate = project.CreationDate;
            return new OkResult();
        }
    }
}
