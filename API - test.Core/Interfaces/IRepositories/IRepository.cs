using API___test.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API___test.Core.Interfaces.IRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();

        //Task<IEnumerable<T>> GetWhere();

        IQueryable<T> FindAsync(Expression<Func<T, bool>> predicate);

        Task<T> GetById(int id);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
