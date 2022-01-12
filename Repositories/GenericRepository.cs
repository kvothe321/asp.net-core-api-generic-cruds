using Microsoft.EntityFrameworkCore;
using MyHealth.ModelContracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using static MyHealth.RepositoryContracts.IGenericRepository;

namespace MyHealth.Repositories
{
    public class GenericRepository<T, TDbContext> : IGenericRepository<T>
        where T : class, IBaseModel
        where TDbContext : DbContext
    {
        private readonly TDbContext _dbContext;

        public GenericRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region CRUD operations. Interface defined methods.
        public async Task<T> CreateAsync(T t)
        {
            _dbContext.Set<T>().Add(t);
            await _dbContext.SaveChangesAsync();
            return t;
        }

        public async Task<T> DeleteAsync(long id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> ReadAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> ReadAsync(long id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<T> UpdateAsync(T t)
        {
            _dbContext.Entry(t).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return t;
        }
        #endregion
    }

}
