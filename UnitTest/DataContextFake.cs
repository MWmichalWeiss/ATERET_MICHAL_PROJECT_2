using ATERET_MICHAL_SCHEDULE.Entities;
using CsvHelper;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class DataContextFake:IDataContext
    {
        public List<Tracer> TeacherList { get; set; }
        public List<TheClass> ClassList { get; set; }
        public List<Lesson> LessonList { get; set; }
        public DataContextFake()
        {
            using (var reader = new StreamReader("dataForTeacherTemp.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                TeacherList = csv.GetRecords<Teacher>().ToList();
            }

        }
    }
}
