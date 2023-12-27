using DevExpress.XtraPrinting;
using System.Formats.Asn1;

namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public interface IDataContext
    {
        public List<Tracer> TeacherList { get; set; }
        public List<TheClass> ClassList { get; set; }
        public List<Lesson> LessonList { get; set; }
    }
}
