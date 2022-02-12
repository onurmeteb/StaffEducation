using StaffEducation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.DataAccess.Concrete.EntityFramework
{

    
    public class StaffEducationContext:DbContext
    {
        public StaffEducationContext()
        {
            //does not create a table that it cannot find in the database.
            //Database.SetInitializer<StaffEducationContext>(null);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonCourse> PersonCourses { get; set; }
        public DbSet<MilitaryType> MilitaryTypes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<DrivingLicance> DrivingLicances { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
