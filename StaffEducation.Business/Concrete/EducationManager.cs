using StaffEducation.Business.Abstract;
using StaffEducation.DataAccess.Abstract;
using StaffEducation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Concrete
{
    public class EducationManager : EducationService<Education>
    {
        private IBaseDal<Education> _educationOperation;

        public EducationManager(IBaseDal<Education> educationOperation)
        {
            _educationOperation = educationOperation;
        }

        public void Add(Education entity)
        {
            _educationOperation.Add(entity);
        }

        public void Delete(Education entity)
        {
            _educationOperation.Delete(entity);
        }

        public Education Get(Expression<Func<Education, bool>> filter)
        {
            return _educationOperation.Get(filter);
        }

        public List<Education> GetAll(Expression<Func<Education, bool>> filter = null)
        {
            return _educationOperation.GetAll(filter);
        }

        public void Update(Education entity)
        {
            _educationOperation.Update(entity);
        }
    }
}
