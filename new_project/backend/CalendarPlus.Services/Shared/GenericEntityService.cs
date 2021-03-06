﻿using CalendarPlus.Product.Contracts.Repositories.Shared;
using CalendarPlus.Product.Contracts.Services.Shared;
using CalendarPlus.Product.Contracts.Shared;
using CalendarPlus.SystemObjects;
using CalendarPlus.SystemObjects.Exceptions;
using CalendarPlus.SystemObjects.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace CalendarPlus.Services.Shared
{
    public abstract class GenericEntityService<TEntity> : IGenericEntityService<TEntity> where TEntity : class, IEntity
    {
        protected readonly IUnitOfWorkFactory<UnitOfWork> _uow;
        protected readonly IGenericRepository<TEntity> _repository;

        public GenericEntityService(IGenericRepository<TEntity> TEntityRepository, IUnitOfWorkFactory<UnitOfWork> uow)
        {
            _repository = TEntityRepository;
            _uow = uow;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken = default, int skip = 0, int take = 20)
        {
            return await _repository.FindAll(cancellationToken, skip, take);
        }

        public virtual async Task<TEntity> GetOneAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _repository.FindOne(id, cancellationToken);
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            using (var uow = _uow.Create())
            {
                TEntity result = await _repository.Create(entity, cancellationToken);
                await uow.CommitAsync(cancellationToken);

                return result;
            }
        }

        public virtual async Task<TEntity> UpdateAsync(int id, TEntity entity, CancellationToken cancellationToken = default)
        {
            using (var uow = _uow.Create())
            {
                TEntity schedule = await _repository.FindOne(id, cancellationToken);

                if (schedule != null && schedule.Id > 0)
                {
                    TEntity result = await _repository.Update(entity, cancellationToken);
                    await uow.CommitAsync(cancellationToken);

                    return result;
                }
                else
                {
                    string message = $"{typeof(TEntity).Name} {id} not found";
                    throw new CalendarPlusApplicationException(message, HttpStatusCode.NotFound);
                }
            }
        }

        public virtual async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            using (var uow = _uow.Create())
            {
                TEntity entity = await _repository.FindOne(id, cancellationToken);

                if (entity != null && entity.Id > 0)
                {
                    await _repository.SoftDelete(entity, cancellationToken);
                    await uow.CommitAsync(cancellationToken);
                }
                else
                {
                    string message = $"{typeof(TEntity).Name} {id} not found";
                    throw new CalendarPlusApplicationException(message, HttpStatusCode.NotFound);
                }
            }
        }
    }
}
