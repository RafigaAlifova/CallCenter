using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new() //generic constraint
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //m=> =m.Id==5

        T Get(Expression<Func<T, bool>> filter);

        int GetNextId();
        void DeleteAll();

    }
}
