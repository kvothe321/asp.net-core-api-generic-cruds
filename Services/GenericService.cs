using MyHealth.ModelContracts;
using MyHealth.ServiceContracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using static MyHealth.RepositoryContracts.IGenericRepository;

namespace MyHealth.Services
{
    public class GenericService<T, TRepository> : IGenericService<T>
        where T : class, IBaseModel
        where TRepository : IGenericRepository<T>
    {
        private readonly TRepository _repository;

        public GenericService(TRepository repository)
        {
            _repository = repository;
        }

        public async Task<T> CreateAsync(T t)
        {
            return await _repository.CreateAsync(t);
        }

        public async Task<T> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<T>> ReadAllAsync()
        {
            return await _repository.ReadAllAsync();
        }

        public async Task<T> ReadAsync(int id)
        {
            return await _repository.ReadAsync(id);
        }

        public async Task<T> UpdateAsync(T t)
        {
            return await _repository.UpdateAsync(t);
        }
    }
}
