using Microsoft.EntityFrameworkCore;
using OC.Domain.Intefaces;
using OC.Domain.Models;
using OC.Infrastructure.Data.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OC.Infrastructure.Data.Repositories.EF
{
    public class EFRepository<T> : IRepository<T> where T : BaseModel
    {
        protected CinemaContext _db;

        public EFRepository(CinemaContext db)
        {
            _db = db;
        }

        public async Task<long> CountAsync()
        {
            return await _db.Set<T>().CountAsync();
        }

        public async Task<long> CountAsync(Expression<Func<T, bool>> match)
        {
            return await _db.Set<T>().CountAsync(match);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task<T> FindByIdAsync(object id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync(bool isTracking = false)
        {
            var models = !isTracking ?
                await _db.Set<T>().AsNoTracking().ToListAsync() :
                 await _db.Set<T>().ToListAsync();
            return models;
        }

        public async Task<List<T>> GetAllAsync(int offset, int count, bool isTracking = false)
        {
            IQueryable<T> entities = _db.Set<T>();
            if (!isTracking)
                entities.AsNoTracking();
            return await entities.Skip(offset).Take(count).ToListAsync();
        }

        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> match, bool isTracking = false)
        {
            if (isTracking)
                return await _db.Set<T>().FirstOrDefaultAsync(match);
            return await _db.Set<T>().AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<T> GetForEditAsync(Expression<Func<T, bool>> match)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(match);
        }

        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> match, bool isTracking = false)
        {
            if (isTracking)
                return await _db.Set<T>().Where(match).ToListAsync();
            return await _db.Set<T>().AsNoTracking().Where(match).ToListAsync();
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> match, bool isTracking = false)
        {
            var entities = await _db.Set<T>().AsNoTracking().Where(match).ToListAsync();
            if (entities == null || entities.Count == 0)
                return false;
            return true;
        }

        public async Task<T> RemoveAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
