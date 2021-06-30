using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace career.DAL.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        List<T> Get();
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        List<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        Task AddAsync(T entity);
        void Delete(T entity);
        void Update(T entity);
        void AddRange(List<T> entity);
        void UpdateRange(List<T> entity);
    }
}
