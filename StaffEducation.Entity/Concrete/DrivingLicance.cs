using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{
    [Table("dbo.DrivingLicances")]
    public class DrivingLicance : EntityBase
    {
        public string LicenceName { get; set; }
    }
}
