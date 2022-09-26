using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Infrastructure.Context;
using System.Linq.Expressions;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly BaseDataContext _context;
        public BaseRepository(BaseDataContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll() => _context.Set<T>().AsNoTracking();

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task Create(T entity)
        {
            _context.Set<T>().Add(entity);

            _context.SaveChanges();
        }

        public async Task Update(int id, T entity)
        {
            _context.Set<T>().Update(entity);
            var be = new Domain.Entities.BaseEntity();
            be.UpdatedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task SoftDelete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }


    }
}
