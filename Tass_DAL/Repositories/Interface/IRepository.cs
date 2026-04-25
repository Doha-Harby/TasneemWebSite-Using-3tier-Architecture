using System.Linq.Expressions;

namespace Tass_DAL.Repositories.Interface
{
    public interface IRepository<T> where T: class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAysnc();
        Task<T> CreateAysnc(T entity);
        Task<T> UpdateAysnc(T entity);
        Task<bool> HardDeleteAysnc(int id);
        //Task<IEnumerable<T>> GetDeletedAsync();
    }
}
