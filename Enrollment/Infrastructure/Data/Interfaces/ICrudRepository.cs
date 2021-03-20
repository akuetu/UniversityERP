using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enrollment.Infrastructure.Data.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetEntityList();
        Task<T> SaveEntity(T entity);
        Task<int> DeleteEntity(T entity);
        Task<int> UpdateEntity(T entity);
        Task<IReadOnlyList<T>> GetByIdAsync(T entity);
    }
}
