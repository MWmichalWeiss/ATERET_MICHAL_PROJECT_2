using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using ATERET_MICHAL_SCHEDULE.Entities;

namespace Solid.Data.Repositories
{
    public class TeacherRepository:ITeacherRepository
    {
        private readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }
        public List<Teacher>GetTeachers()
        {
            return _context.TeacherList;
        }
        public Teacher GetById(int id)
        {
           var teacher= _context.TeacherList.Find(e => e.Id == id);
            if(teacher!=null)
                return teacher;
            return null;
        }
        public int GetSeniority(int id, string subject)
        {
            var teacher = _context.TeacherList.Find(e => e.Id == id);
            return teacher.Seniority;
        }
        public Teacher AddTeacher(Teacher teachar)
        {
            _context.TeacherList.Add(teachar);
            return teachar;
        }
        public Teacher UpdateTeacher(int id, Teacher teacher)
        {
            var t = _context.TeacherList.Find(e => e.Id == id);
            if (teacher != null)
            {
                t.Subject=teacher.Subject;
                t.Seniority=teacher.Seniority;
                return t;
            }
            return null;
        }
        public void DeleteTeacher(int id)
        {
            var teacher = _context.TeacherList.Find(e => e.Id == id);
            if (teacher != null)
                _context.TeacherList.Remove(teacher);

        }
    }
}
