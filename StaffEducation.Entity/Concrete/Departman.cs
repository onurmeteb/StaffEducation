using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{

    [Table("dbo.Departmans")]
    public class Departman : EntityBase
    {
        public string DepartmanName { get; set; }
    }
}
