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


    public class PersonManager : IPersonsService<Person>
    {
        
        private IBaseDal<Person> _personOperation;

        //public PersonManager(PersonOperation personOperation)
        //!---!!
        public PersonManager(IBaseDal<Person> personOperation)
        {
            _personOperation = personOperation;
        }

        public void Add(Person entity)
        {
             _personOperation.Add(entity);
        }

        public void Delete(Person entity)
        {
            _personOperation.Delete(entity);
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            return _personOperation.Get(filter);    
        }

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
           return _personOperation.GetAll(filter);
        }

        public void Update(Person entity)
        {
           _personOperation.Update(entity);
        }
    }
}
