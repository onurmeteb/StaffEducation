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
    public class DrivingLicanceManager : DrivingLicanceService<DrivingLicance>
    {
        private IBaseDal<DrivingLicance> _drivincLicanceOperation;

        public DrivingLicanceManager(IBaseDal<DrivingLicance> drivincLicanceOperation)
        {
            _drivincLicanceOperation = drivincLicanceOperation;
        }

        public void Add(DrivingLicance entity)
        {
            _drivincLicanceOperation.Add(entity);
        }

        public void Delete(DrivingLicance entity)
        {
            _drivincLicanceOperation.Delete(entity);
        }

        public DrivingLicance Get(Expression<Func<DrivingLicance, bool>> filter)
        {
            return _drivincLicanceOperation.Get(filter);
        }

        public List<DrivingLicance> GetAll(Expression<Func<DrivingLicance, bool>> filter = null)
        {
          return _drivincLicanceOperation.GetAll(filter);
        }

        public void Update(DrivingLicance entity)
        {
            _drivincLicanceOperation.Update(entity);
        }
    }
}
