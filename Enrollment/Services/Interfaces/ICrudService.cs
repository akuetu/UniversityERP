using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enrollment.Services.Interfaces
{
    public interface ICrudService<T> where T : class
    {
        Task<IReadOnlyList<T>> GetEntityList();
        Task<T> SaveEntity(T entity);
        Task<int> DeleteEntity(T entity);
        Task<int> UpdateEntity(T entity);
    }
}
