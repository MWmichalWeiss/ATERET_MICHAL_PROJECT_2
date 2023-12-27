using ATERET_MICHAL_SCHEDULE.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class LessonRepository:ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public List<Lesson> GetLessons()
        {
            return _context.LessonList;
        }
        public Lesson GetLessonById(int id)
        {
            var lesson = _context.LessonList.First(x => x.Id == id);
            if (lesson != null)
                return lesson;
            return null;
        }
        public int GetLessonCost(int id, string jabject)
        {
            var lesson = _context.LessonList.First(x => x.Id == id);
            if (lesson != null)
                return lesson.LessonCost;
            return 0;
        }
        public Lesson AddLesson(Lesson lesson)
        {
            _context.LessonList.Add(lesson);
            return lesson;
        }
        public Lesson UpdateLesson(int id, Lesson lesson)
        {
            var l = _context.LessonList.First(x => x.Id == id);
            if (lesson != null)
            {
                l.Subject = lesson.Subject;
                l.timesInWeek = lesson.timesInWeek;
                l.LessonCost = lesson.LessonCost;
                return l;
            }
            return null;
        }
        public void DeleteLesson(int id)
        {
            var lesson = _context.LessonList.First(x => x.Id == id);
            if (lesson == null)
                _context.LessonList.Remove(lesson);
        }
    }
}
