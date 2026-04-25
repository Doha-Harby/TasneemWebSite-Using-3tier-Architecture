
using System.Linq.Expressions;

namespace Tass_DAL.Repositories.Implementation
{
    public class Repository<T>(TasneemContext context) : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task<T?> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<IEnumerable<T>> GetAllAysnc()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> CreateAysnc(T entity)
        {
            await _dbSet.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity; 
        }
        public async Task<T> UpdateAysnc(T entity)
        {
            _dbSet.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }
        public async Task<bool> HardDeleteAysnc(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null) 
                return false;
            _dbSet.Remove(entity);
            await context.SaveChangesAsync(); 
            return true;
        } 
    }
}
