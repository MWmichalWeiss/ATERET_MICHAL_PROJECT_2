using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATERET_MICHAL_SCHEDULE.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
namespace Solid.Service
{
    public class ClassService:IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
            classRepository = _classRepository;
        }

        public List<TheClass> GetTeachers()
        {
            return _classRepository.GetClasses();
        }
        public TheClass GetById(int id)
        {
            return _classRepository.GetById(id);
        }
    }
}
