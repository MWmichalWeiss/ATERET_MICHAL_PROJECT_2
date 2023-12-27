namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class Lesson
    {
        public int Id { get; }
        public string Subject { get; set; }
        public int timesInWeek { get; set; }
        public int LessonCost { get; set; }
        static int tmpId = 895;

        public Lesson()
        {
            Id = tmpId;
            tmpId += 7;
        }
    }
}
