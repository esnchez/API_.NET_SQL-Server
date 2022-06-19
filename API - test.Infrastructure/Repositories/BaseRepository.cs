using API___test.Core.Entities;
using API___test.Core.Interfaces.IRepositories;
using API___test.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace API___test.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
           return await _entities.ToListAsync();
        }

        public IQueryable<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return _entities.Where(predicate) ;
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }
        public async Task Add(T entity)
        {
            _entities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);
            await _context.SaveChangesAsync();

        }


    }
}
