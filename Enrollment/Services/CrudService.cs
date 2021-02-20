using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Repository;
using Enrollment.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enrollment.Services
{

    public class CrudService<T>: CrudRepository<T>,ICrudService<T> where T: class
    {
        public CrudService(EnrollmentContext enrollmentContext): base(enrollmentContext){}

        public async Task<int> DeleteCountry(T entity)
        {
            return await DeleteAsync(entity);
        }

        public async Task<IReadOnlyList<T>> GetCountryList()
        {
            return await GetEntityList();
        }

        public async Task<T> SaveCountry(T entity)
        {
            return await SaveEntity(entity);
        }

        public async Task<int> UpdateCountry(T entity)
        {
            return await UpdateAsync(entity);
        }
    }
}
