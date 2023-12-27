using ATERET_MICHAL_SCHEDULE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface ITeacherService
    {
        List<Teacher>GetTeachers();
        Teacher GetById(int id);
    }
}
