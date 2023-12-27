namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class Teacher
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Seniority { get; set; }
        static int tmpId = 123;
        public Teacher()
        {
            Id = tmpId;
            tmpId += 96;
        }
    }
}
