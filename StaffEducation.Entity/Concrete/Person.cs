using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Entity.Concrete
{
    [Table("dbo.Persons")]
    public class Person : EntityBase
    {
        public DateTime DateOfStart { get; set; }
        public string Name { get; set; }  
        public string Surname { get; set; }
        public Int64 DepartmentID { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public string MailAddress { get; set; }
        public string MaritalStatus { get; set; }
        public Int64 EducationID { get; set; }
        public string JobExperience { get; set; }
        public Int64 DrivingLicenceID { get; set; }
        public string HomeAddress { get; set; }
        public Int64 MilitaryStatusID { get; set; }
        public DateTime? BirthDate { get; set; }
    
    }
}
