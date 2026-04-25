namespace Tass_BLL.Services.Implementation
{
    public class Service<T>(IRepository<T> repository) : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository = repository;

        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAysnc();
        public async Task<T?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);
        public async Task<T> CreateAsync(T entity) => await _repository.CreateAysnc(entity);      
        public async Task<T> UpdateAsync(T entity) => await _repository.UpdateAysnc(entity);
        public async Task<bool> HardDeleteAsync(int id) => await _repository.HardDeleteAysnc(id);
    }
}