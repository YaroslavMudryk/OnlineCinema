using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace OC.Domain.Intefaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> RemoveAsync(T entity);
        Task<bool> IsExistAsync(Expression<Func<T, bool>> match, bool isTracking = false);
        Task<T> FindByIdAsync(object id);
        Task<List<T>> GetAllAsync(bool isTracking = false);
        Task<List<T>> GetAllAsync(int offset, int count, bool isTracking = false);
        Task<long> CountAsync(bool isTracking = false);
        Task<long> CountAsync(Expression<Func<T, bool>> match, bool isTracking = false);
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> match, bool isTracking = false);
        Task<T> GetFirstAsync(Expression<Func<T, bool>> match, bool isTracking = false);
        Task<T> GetForEditAsync(Expression<Func<T, bool>> match);
        void Dispose();
    }
}