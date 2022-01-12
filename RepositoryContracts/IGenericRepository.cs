using MyHealth.ModelContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyHealth.RepositoryContracts
{
    public interface IGenericRepository
    {
        /// <summary>
        /// Contract interface for the GenericRepository class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IGenericRepository<T> where T : class, IBaseModel
        {
            /// <summary>
            /// Retrieves all T entities from the database.
            /// </summary>
            /// <returns></returns>
            Task<List<T>> ReadAllAsync();

            /// <summary>
            /// Retrieves the generic T entity with @id=id from the database.
            /// </summary>
            /// <param name="id">Entity's Identifier</param>
            /// <returns></returns>
            Task<T> ReadAsync(long id);

            /// <summary>
            /// Inserts a generic T entity into database.
            /// </summary>
            /// <param name="t"></param>
            /// <returns></returns>
            Task<T> CreateAsync(T t);

            /// <summary>
            /// Updates a generic entity
            /// </summary>
            /// <param name="t"></param>
            /// <returns></returns>
            Task<T> UpdateAsync(T t);

            /// <summary>
            /// Deletes a generic T entity from database.
            /// </summary>
            /// <param name="id">Entity's identifier</param>
            /// <returns></returns>
            Task<T> DeleteAsync(long id);
        }

    }
}
