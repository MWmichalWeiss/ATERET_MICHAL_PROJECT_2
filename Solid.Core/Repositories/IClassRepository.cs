using ATERET_MICHAL_SCHEDULE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClassRepository
    {
        List<TheClass> GetClasses();
        TheClass GetById(int id);
        int GetNumStudentInClass(int id, int valueNumClass);
        TheClass AddClass(TheClass tClass);
        TheClass UpdateClass(int id, TheClass tClass);
        void DeleteClass(int id);
    }
}
