using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{
    public class PersonCourse : EntityBase
    {
        public Int64 CourseID { get; set; }
        public Int64 PersonelID { get; set; }
    }
}
