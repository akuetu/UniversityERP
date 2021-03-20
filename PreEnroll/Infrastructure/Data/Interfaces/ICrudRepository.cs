using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enrollment.Infrastructure.Data.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {
        Task<T> Execute(T entity);
        Task<T> GetById(T entity);
        Task<IEnumerable<T>> GetList();
        Task<T> Save(T entity);
        Task<T> Delete(T entity);
        Task<T> Update(T entity);
    }
}
