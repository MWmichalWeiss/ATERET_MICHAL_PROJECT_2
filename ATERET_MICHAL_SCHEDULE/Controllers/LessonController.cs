using ATERET_MICHAL_SCHEDULE.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATERET_MICHAL_SCHEDULE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private DataContext dataContext;
        public LessonController(DataContext data)
        {
            dataContext = data;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return dataContext.LessonList;
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Lesson> Get(int id)
        {
            var lesson= dataContext.LessonList.First(x => x.Id == id);
            if(lesson == null)
                return NotFound();
            return lesson;
        }

        // POST api/<LessonController>
        // GET api/<LessonController>/5
        [HttpGet("{id},{subject}")]
        public ActionResult<int> Get(int id, string jabject)
        {
            var lesson = dataContext.LessonList.First(x => x.Id == id);
            if(lesson == null)
                return NotFound();
            return lesson.LessonCost;
        }
        // POST api/<LessonController>
        [HttpPost]
        public void Post(string nameSubject, int timesAWeek, int lessonCost)
        {
            dataContext.LessonList.Add(new Lesson() { Subject = nameSubject, timesInWeek = timesAWeek, LessonCost = lessonCost });
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public void Put(int id, string nameSubject, int timesAWeek, int lessonCost)
        {
            var lesson = dataContext.LessonList.First(x => x.Id == id);
            if (lesson == null)
                 NotFound();
            lesson.Subject=nameSubject;
            lesson.timesInWeek=timesAWeek;
            lesson.LessonCost=lessonCost;
        }
        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var lesson = dataContext.LessonList.First(x => x.Id == id);
            if (lesson == null)
                NotFound();
            dataContext.LessonList.Remove(lesson);
        }
    }
}
