using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.DataAccess.Abstract
{
    public interface IBaseDal <T> where T : class,IEntityBase,new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);

    }
}
