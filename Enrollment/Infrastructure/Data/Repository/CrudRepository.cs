using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.Base;
using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Interfaces;

namespace Enrollment.Infrastructure.Data.Repository
{


    public class CrudRepository<T>: BaseRepository<T>, ICrudRepository<T> where T : class
    {
   
        public CrudRepository(EnrollmentContext dbContext):base(dbContext) {}

        public async Task<int> DeleteEntity(T entity)
        {
            return await DeleteAsync(entity);
        }

        public Task<IReadOnlyList<T>> GetByIdAsync(T entity) 
        {
            throw new System.NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetEntityList()
        {
            return await ListAllAsync();
        }

        public async Task<T> SaveEntity(T entity)
        {
            return await AddAsync(entity);
        }

        public async Task<int> UpdateEntity(T entity)
        {
            return await UpdateAsync(entity);
        }
    }
}
