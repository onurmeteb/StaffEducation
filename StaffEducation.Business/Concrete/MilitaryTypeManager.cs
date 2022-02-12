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
    public class MilitaryTypeManager : MilitaryTypeService<MilitaryType>
    {
        private IBaseDal<MilitaryType> _militaryTypeOperation;

        public MilitaryTypeManager(IBaseDal<MilitaryType> militaryTypeOperation)
        {
            _militaryTypeOperation = militaryTypeOperation;
        }

        public void Add(MilitaryType entity)
        {
            _militaryTypeOperation.Add(entity);
        }

        public void Delete(MilitaryType entity)
        {
            _militaryTypeOperation.Delete(entity);
        }

        public MilitaryType Get(Expression<Func<MilitaryType, bool>> filter)
        {
            return _militaryTypeOperation.Get(filter);
        }

        public List<MilitaryType> GetAll(Expression<Func<MilitaryType, bool>> filter = null)
        {
            return _militaryTypeOperation.GetAll(filter);
        }

        public void Update(MilitaryType entity)
        {
            _militaryTypeOperation.Update(entity);
        }
    }
}
