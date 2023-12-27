using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace ATERET_MICHAL_SCHEDULE.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Teacher> TeacherList { get; set; }
        public DbSet<Lesson> LessonList { get; set; }
        public DbSet<TheClass> ClassList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }


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
