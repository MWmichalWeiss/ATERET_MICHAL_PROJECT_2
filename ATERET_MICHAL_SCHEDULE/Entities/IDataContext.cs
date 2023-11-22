namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public interface IDataContext
    {
        public List<Teacher> TeacherList { get; set; }
        public List<TheClass> ClassList { get; set; }
        public List<Lesson> LessonList { get; set; }
    }
}
