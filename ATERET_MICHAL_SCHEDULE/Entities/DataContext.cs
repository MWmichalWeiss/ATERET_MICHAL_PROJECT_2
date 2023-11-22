using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using Microsoft.Extensions.Logging;


namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class DataContext : IDataContext
    {
        public List<Teacher> TeacherList { get; set; }
        public List<Lesson> LessonList { get; set; }
        public List<TheClass> ClassList { get; set; }


        public DataContext()
        {
            using (var reader=new StreamReader("dataForTeacher.csv"))
            using(var csv=new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                TeacherList = csv.GetRecords<Teacher>().ToList();
            }

            using (var reader = new StreamReader("dataForClass.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                ClassList = csv.GetRecords<TheClass>().ToList();
            }

            using (var reader = new StreamReader("dataForTeacher.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                LessonList = csv.GetRecords<Lesson>().ToList();
            }
        }
    }
}
