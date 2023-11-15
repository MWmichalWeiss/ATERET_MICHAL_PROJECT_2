namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class DataContext
    {
        public List<Teacher> TeacherList { get; set; }
        public List<Lesson> LessonList { get; set; }
        public List<TheClass> ClassList { get; set; }


        public DataContext()
        {
            TeacherList = new List<Teacher>()
            {
                new Teacher(){Name="milka kraft",Subject="dinim",Seniority=30 },
                new Teacher(){Name="menucha cohen",Subject="yahadut",Seniority=25},
                new Teacher(){Name="dvora weiss",Subject="mesilat yesharim",Seniority=1},
                new Teacher(){Name="hodaya bozaglo",Subject="math",Seniority=5},
                new Teacher(){Name="ester shpith",Subject="english",Seniority=3}
            };
            LessonList = new List<Lesson>()
            {
                new Lesson(){ Subject="Math",timesInWeek=5,LessonCost=350},
                new Lesson(){ Subject="dinim",timesInWeek=3,LessonCost=120},
                new Lesson(){ Subject="mesilat yesharim",timesInWeek=1,LessonCost=150},
                new Lesson(){ Subject="english",timesInWeek=4,LessonCost=320},
                new Lesson(){ Subject="yahadut",timesInWeek=2,LessonCost=200}
            };
            ClassList = new List<TheClass>()
            {
               new TheClass() { Grade="V",NumClass=2,NumStudentsInClass=45},
               new TheClass() { Grade="H",NumClass=10,NumStudentsInClass=42},
               new TheClass() { Grade="D",NumClass=5,NumStudentsInClass=40},
               new TheClass() { Grade="G",NumClass=4,NumStudentsInClass=48},
               new TheClass() { Grade="B",NumClass=3,NumStudentsInClass=52},
               new TheClass() { Grade="A",NumClass=7,NumStudentsInClass=50}
            };
        }
    }
}
