using ATERET_MICHAL_SCHEDULE.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATERET_MICHAL_SCHEDULE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private DataContext dataContext;
        public ClassController(DataContext data)
        {
            dataContext = data;
        }
        // GET: api/<ClassController>
        [HttpGet]
        public IEnumerable<TheClass> Get()
        {
            return dataContext.ClassList;
        }

        // GET api/<ClassController>/5
        [HttpGet("{id}")]
        public ActionResult<TheClass> Get(int id)
        {
            var cla=dataContext.ClassList.Find(x => x.Id == id);
            if (cla == null)
                return NotFound();
            return cla;
        }

        [HttpGet("{id},{numClass}")]
        public ActionResult<int> Get(int id, int valueNumClass)
        {
            var cla = dataContext.ClassList.Find(x => x.Id == id);
            if (cla == null)
                return NotFound();
            return cla.NumStudentsInClass;
        }
        // POST api/<ClassController>
        [HttpPost]
        public void Post(string valueGrade, int valueNumClass, int valueNumStudentsInClass)
        {
            dataContext.ClassList.Add(new TheClass() { Grade = valueGrade, NumClass = valueNumClass, NumStudentsInClass = valueNumStudentsInClass });
        }
        // PUT api/<ClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, int valueNumClass, int valueNumStudentsInClass)
        {
            var cla = dataContext.ClassList.Find(x => x.Id == id);
            if (cla == null)
                 NotFound();
            cla.NumClass=valueNumClass;
            cla.NumStudentsInClass=valueNumStudentsInClass;
        }

        // DELETE api/<ClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cla = dataContext.ClassList.First(x => x.Id == id);
            if (cla == null)
                NotFound();
            dataContext.ClassList.Remove(cla);
        }
    }
}
