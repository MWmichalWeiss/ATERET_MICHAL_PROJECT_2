using ATERET_MICHAL_SCHEDULE;
using ATERET_MICHAL_SCHEDULE.Controllers;
using ATERET_MICHAL_SCHEDULE.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest
{
    public class TeacherControllerTest
    {
        private readonly TeacherController _teacherController;
        public TeacherControllerTest()
        {
            var context = new DataContextFake();
            _teacherController = new TeacherController((ATERET_MICHAL_SCHEDULE.Entities.IDataContext)context);
        }
        [Fact]
        public void Get_ReturnsOk()
        {
            IEnumerable<Teacher>result= (IEnumerable<Teacher>)_teacherController.Get();
            int resultLength = result.Count();
            Assert.Equal(5, resultLength);
        }
        [Fact]
        public void Get_by_id_returnOk()
        {
            var id = 58;
            var result = _teacherController.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetByIdNotFound()
        {
            var result = _teacherController.Get();
            Assert.IsType<NotFoundObjectResult>(result);
        }

    }
}