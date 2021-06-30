using career.DAL.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class, new()
    {
        DbContext _context;
        DbSet<T> _dbSet;

        public EfEntityRepositoryBase(CareerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void AddRange(List<T> entity)
        {
            _dbSet.AddRange(entity);
        }

        public void Delete(T entity)
        {
            T existing = _dbSet.Find(entity);
            if (existing != null) _dbSet.Remove(existing);
        }

        public List<T> Get()
        {
            return _dbSet.ToList();
        }

        public List<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefaultAsync();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _dbSet.Update(entity);
        }

        public void UpdateRange(List<T> entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.UpdateRange(entity);
        }
    }
}

