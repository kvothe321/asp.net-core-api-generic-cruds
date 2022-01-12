using MyHealth.ModelContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHealth.ServiceContracts
{
    public interface IGenericService<T>
        where T : class, IBaseModel
    {
        /// <summary>
        /// Retrieves all generic entities from the repository.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> ReadAllAsync();

        /// <summary>
        /// Retrieves a generic entity from the repository.
        /// </summary>
        /// <param name="id">Entity's Identifier</param>
        /// <returns></returns>
        Task<T> ReadAsync(int id);

        /// <summary>
        /// Sends a generic entity to the repository for database insertion.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<T> CreateAsync(T t);

        /// <summary>
        /// Sends a generic entity to the repository for database entity update.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T t);

        /// <summary>
        /// Deletes a generic entity through repository.
        /// </summary>
        /// <param name="id">Entity's identifier</param>
        /// <returns></returns>
        Task<T> DeleteAsync(int id);
    }
}
