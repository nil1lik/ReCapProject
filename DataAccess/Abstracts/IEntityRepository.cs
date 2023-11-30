using System;
using System.Linq.Expressions;
using Entities.Abstracts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IEntityRepository<T>where T:class,IEntity, new()
	{
        List<T> GetAll(Expression<Func<T, bool>>filter=null);
        T Get(Expression<Func<T, bool>>filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}

