using ATERET_MICHAL_SCHEDULE.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    internal class ClassRepository:IClassRepository
    {
        private readonly DataContext _context;
        public ClassRepository(DataContext context)
        {
            _context = context;
        }
        public List<TheClass> GetClasses()
        {
            return _context.ClassList;
        }
        public TheClass GetById(int id)
        {
            var cla = _context.ClassList.Find(x => x.Id == id);
            if (cla != null)
                return cla;
            return null;
        }
        public int GetNumStudentInClass(int id, int valueNumClass)
        {
            var cla =_context.ClassList.Find(x => x.Id == id);
            if (cla != null)
                return cla.NumStudentsInClass;
            return 0;
        }
        public TheClass AddClass(TheClass tClass)
        {
            _context.ClassList.Add(tClass);
            return tClass;
        }
        public TheClass UpdateClass(int id, TheClass tClass)
        {
            var cla = _context.ClassList.Find(x => x.Id == id);
            if (cla != null)
            {
                cla.NumClass = tClass.NumClass;
                cla.NumStudentsInClass = tClass.NumStudentsInClass;
                return cla;
            }
            return null;
        }
        public void DeleteClass(int id)
        {
            var cla = _context.ClassList.First(x => x.Id == id);
            if (cla != null)
            _context.ClassList.Remove(cla);
        }
    }
}
