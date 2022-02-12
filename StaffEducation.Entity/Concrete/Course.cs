using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{
    public class Course : EntityBase
    {
        public DateTime? CourseDate { get; set; }
        public string CourseName { get; set; }
        public string CompanyName { get; set; }
        public string CourseSubject { get; set; }
        public string CourseTeacher { get; set; }
        public int? CourseTime { get; set; }
    }
}
