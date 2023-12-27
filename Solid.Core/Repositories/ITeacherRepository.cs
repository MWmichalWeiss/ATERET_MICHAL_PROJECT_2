using ATERET_MICHAL_SCHEDULE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetTeachers();
        Teacher GetById(int id);
        int GetSeniority(int id, string subject);
        Teacher AddTeacher(Teacher teacher);
        Teacher UpdateTeacher(int id, Teacher teacher);
        void DeleteTeacher(int id);


    }
}
