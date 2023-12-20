using Application.Common;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Persistence.PostGreSql.Repositories
{
    internal class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly DatabaseContext Context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DatabaseContext context)
        {
            Context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll() => Context.Set<T>();

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<PagedResult<T>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null)
        {
            IQueryable<T> query = _dbSet;
            if (includes != null)
            {
                query = includes(query);
            }
            return expression != null ? await query.Where(expression).GetPaged(pageNumber, pageSize) :
                    await query.GetPaged(pageNumber, pageSize);
        }

    }
}