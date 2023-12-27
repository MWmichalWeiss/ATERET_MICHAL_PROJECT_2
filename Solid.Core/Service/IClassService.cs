using ATERET_MICHAL_SCHEDULE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    internal interface IClassService
    {
        List<TheClass> GetTeachers();
        TheClass GetById(int id);
    }
}
