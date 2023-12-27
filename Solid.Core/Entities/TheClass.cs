namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class TheClass
    {
        public int Id { get; }
        public string Grade { get; set; }
        public int NumClass { get; set; }
        public int NumStudentsInClass { get; set; }
        static int tmpId = 11;
        public TheClass()
        {
            Id = tmpId++;
        }
    }
}
