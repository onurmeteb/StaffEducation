using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.Business.Abstract
{
    public interface IBaseService<T>
    {
        BaseResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        BaseResult<T> Get(Expression<Func<T, bool>> filter);
        BaseResult<bool> Delete(T entity);
        BaseResult<bool> Add(T entity);
        BaseResult<bool> Update(T entity);
    }
}
