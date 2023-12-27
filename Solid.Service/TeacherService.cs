using ATERET_MICHAL_SCHEDULE.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public List<Teacher> GetTeachers()
        {
            return _teacherRepository.GetTeachers();
        }
        public Teacher GetById(int id)
        {
            return _teacherRepository.GetById(id);
        }
    }
}
