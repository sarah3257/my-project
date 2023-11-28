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
    public class ProjectsService : IProjectsService
    {
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService (IProjectsRepository projectsRepository)
        {
          _projectsRepository = projectsRepository;
        }

        public ActionResult Delete(int id)
        {
            return _projectsRepository.Delete(id);
        }

        public IEnumerable<Projects> Get()
        {
            return _projectsRepository.Get();
        }

        public ActionResult<Projects> Get(int id)
        {
            return _projectsRepository.Get(id);
        }

        public void Post([FromBody] Projects project)
        {
            _projectsRepository.Post(project);
        }

        public ActionResult Put(int id, [FromBody] Projects project)
        {
            return _projectsRepository.Put(id, project);    
        }
    }
}
