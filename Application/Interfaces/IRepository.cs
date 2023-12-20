using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        Task<PagedResult<T>> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? expression = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null);
    }
}
