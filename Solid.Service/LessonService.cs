using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATERET_MICHAL_SCHEDULE.Entities;
using Solid.Core.Service;

namespace Solid.Service
{
    public class LessonService: ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public List<Lesson> GetTeachers()
        {
            return _lessonRepository.GetLessons();
        }
        public Lesson GetById(int id)
        {
            return _lessonRepository.GetLessonById(id);
        }
    }
}
