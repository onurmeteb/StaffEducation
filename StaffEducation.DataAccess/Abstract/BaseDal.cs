using StaffEducation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StaffEducation.DataAccess.Abstract
{
    public class BaseDal<TEntity, TContext> : IBaseDal<TEntity>
        where TEntity : class, IEntityBase, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                entity.DataStatus = 1;
                DbEntityEntry<TEntity> contextEntity = context.Entry(entity);
                contextEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                try
                {
                    entity.DataStatus = 0;
                    DbEntityEntry contextEntity = context.Entry(entity);
                    contextEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch 
                {
   
                }


            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                var compiled = filter.Compile();
                //filter = x => compiled(x) && x.DataStatus == 1;//buna bakıalcak
                return context.Set<TEntity>().Single(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                if (filter == null)
                {
                    return context.Set<TEntity>().Where(x => x.DataStatus == 1).ToList();
                }
                else
                {
                    var compiled = filter.Compile();
                    filter = i => compiled(i) && i.DataStatus == 1;
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context =new TContext())
            {

                DbEntityEntry contextEntity = context.Entry(entity);
                contextEntity.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
    }
}
