using ATERET_MICHAL_SCHEDULE.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATERET_MICHAL_SCHEDULE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private DataContext dataContext;
        public TeacherController(DataContext data)
        {
            dataContext= data;
        }
        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return dataContext.TeacherList;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var teacher = dataContext.TeacherList.Find(e => e.Id == id);
            if(teacher==null)
                return NotFound();
            return teacher;
        }
        [HttpGet("{id},{subject}")]
        public ActionResult<int> Get(int id, string subject)
        {
            var teacher=dataContext.TeacherList.Find(e=>e.Id == id);
            if(teacher==null)
                return NotFound();
            return teacher.Seniority;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public void Post(string valueName, string valueSubject, int valueSeniority)
        {
            dataContext.TeacherList.Add(new Teacher() { Name = valueName, Subject = valueSubject, Seniority = valueSeniority });
        }
        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public void Put(int id, string valueSubject, int valueSeniority)
        {
            var teacher = dataContext.TeacherList.Find(e => e.Id == id);
            if (teacher == null)
                 NotFound();
            teacher.Subject = valueSubject;
            teacher.Seniority = valueSeniority;
        }
        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var teacher = dataContext.TeacherList.Find(e => e.Id == id);
            if(teacher== null)
                NotFound();
            dataContext.TeacherList.Remove(teacher);
        }
    }
}
