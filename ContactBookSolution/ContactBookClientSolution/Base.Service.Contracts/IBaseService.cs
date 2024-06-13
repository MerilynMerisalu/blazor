﻿using Base.Contracts.Domain;
using System.Linq.Expressions;

namespace Base.Service.Contracts
{
    public interface IBaseService<TEntity> : IBaseService<TEntity, Guid>
        where TEntity : class, IDomainEntityId
    {
    }

    public interface IBaseService<TEntity, TKey>
        where TEntity : class, IDomainEntityId<TKey>
        where TKey : IEquatable<TKey>
    {
        //TEntity Add(TEntity entity);
        //Task<List<TEntity>> AddRangeAsync(List<TEntity> entities);
        //TEntity Update(TEntity entity);
        //TEntity Remove(TEntity entity, bool hardDelete = false);
        //TEntity Remove(TKey id, bool hardDelete = false);


        //List<TEntity> RemoveAll(List<TEntity> entities);
        //TEntity? FirstOrDefault(TKey id, bool noTracking = true, bool noIncludes = false);
        IEnumerable<TEntity?>? GetAll(/*bool noTracking = true*/);
        //bool Exists(TKey id);
        //bool Any(Expression<Func<TEntity?, bool>> filter, bool noTracking = true);
        //TEntity? SingleOrDefault(Expression<Func<TEntity?, bool>> filter, bool noTracking = true);

        //TEntity? First(bool noTracking = true, bool noIncludes = false);


        // async
        // List<TEntity> AddRange(List<TEntity> entities);
        // Task<TEntity?> FirstOrDefaultAsync(TKey id, bool noTracking = true, bool noIncludes = false);
        Task<IEnumerable<TEntity?>>? GetAllAsync(/*bool noTracking = true*/);
        //Task<bool> ExistsAsync(TKey id);
        //Task<TEntity> RemoveAsync(TKey id);
        // Task<bool> AnyAsync(Expression<Func<TEntity?, bool>> filter, bool noTracking = true);
        //Task<TEntity?> SingleOrDefaultAsync(Expression<Func<TEntity?, bool>> filter, bool noTracking = true);
        //Task<TEntity?> FirstAsync(bool noTracking = true, bool noIncludes = false);


    }
}