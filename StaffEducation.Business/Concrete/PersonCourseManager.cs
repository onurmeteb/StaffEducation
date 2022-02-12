using StaffEducation.Business.Abstract;
using StaffEducation.DataAccess.Abstract;
using StaffEducation.DataAccess.Concrete;
using StaffEducation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Concrete
{
    public class PersonCourseManager : IPersonCourseService<PersonCourse>
    {
        private IBaseDal<PersonCourse> _personCourseOperation;

        public PersonCourseManager(IBaseDal<PersonCourse> personCourseOperation)
        {
            _personCourseOperation = personCourseOperation;
        }

        public void Add(PersonCourse entity)
        {
            _personCourseOperation.Add(entity);
        }

        public void Delete(PersonCourse entity)
        {
            _personCourseOperation.Delete(entity);
        }

        public PersonCourse Get(Expression<Func<PersonCourse, bool>> filter)
        {
           return _personCourseOperation.Get(filter);
        }

        public List<PersonCourse> GetAll(Expression<Func<PersonCourse, bool>> filter = null)
        {
            return _personCourseOperation.GetAll(filter);
        }

        public void Update(PersonCourse entity)
        {
            _personCourseOperation.Update(entity);
        }
    }
}
