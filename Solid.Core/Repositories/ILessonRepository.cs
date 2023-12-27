using ATERET_MICHAL_SCHEDULE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ILessonRepository
    {
        List<Lesson> GetLessons();
        Lesson GetLessonById(int id);
        int GetLessonCost(int id, string jabject);
        Lesson AddLesson(Lesson lesson);
        Lesson UpdateLesson(int id,Lesson lesson);
        void DeleteLesson(int id);
    }
}
