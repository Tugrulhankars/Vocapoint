using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories;

public interface IAsyncRepository<TEntity,TId>
{
    Task<TEntity> GetAsync(
        Expression<Func<TEntity,bool>> predicate,
        bool withDeleted=false,
        bool enableTracking=true,
        CancellationToken cancellationToken=default);

    Task<List<TEntity>> GetListAsync(
      Expression<Func<TEntity, bool>>? predicate = null,
      Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
      Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
      int index = 0,
      int size = 10,
      bool withDeleted = false,
      bool enableTracking = true,
      CancellationToken cancellationToken = default);

    Task<bool> AnyAsync(
        Expression<Func<TEntity,bool>>? predicate=null,
        bool withDeleted=false,
        bool enableTracking=true,
        CancellationToken cancellationToken=default);

    // Add
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default);

    // Update
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken = default);

    // Delete
    Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false, CancellationToken cancellationToken = default);
    Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false, CancellationToken cancellationToken = default);
}
