using ProductAccelerator.CRUDLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);

        Task<T> GetById(int id);

        Task Create(T entity);

        Task Update(int id, T entity);

        Task Delete(T entity);

        Task SoftDelete(T entity);
    }
}
