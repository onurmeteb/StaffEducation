using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{
    public class Education : EntityBase
    {
        public string EducationName { get; set; }
    }
}
