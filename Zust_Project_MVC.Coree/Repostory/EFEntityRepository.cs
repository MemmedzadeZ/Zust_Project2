﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Zust_Project_MVC.Coree.DataAccess;

namespace Zust_Project_MVC.Coree.Repostory
{
    public class EFEntityRepository<TEntity, TContext> : IEFEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext
    {
        private readonly TContext _context;

        public EFEntityRepository(TContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity) // IEntity yerine TEntity kullanıyoruz
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var updateedEntity = _context.Entry(entity);
            updateedEntity.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter) // IEntity yerine TEntity
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            return 
                await _context.Set<TEntity>().Where(filter).ToListAsync();
        }
    }

}
