﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ListaTelefonica.Domain.Interfaces.Services
{
	public interface IServiceBase<TEntity> where TEntity : class
	{
		Task<TEntity> GetByIdAsync(int id);
		Task<IEnumerable<TEntity>> GetAllAsync();
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
		Task AddAsync(TEntity entity);
		Task AddRangeAsync(IEnumerable<TEntity> entities);
		void Remove(TEntity entity);
		void Update(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
		Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
		void Dispose();
	}
}
