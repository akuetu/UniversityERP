using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.Base;
using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;

namespace Enrollment.Infrastructure.Data.Repository
{
    public class UserEnrollmentRepository: BaseRepository<UserEnrollment>, IUserEnrollmentRepository
    {
   
        public UserEnrollmentRepository(EnrollmentContext dbContext):base(dbContext) {}


        public async Task<IReadOnlyList<UserEnrollment>> GetEnrollment()
        {
            return await ListAllAsync();
        }

        public async Task<UserEnrollment> SaveEnrollment(UserEnrollment enrollment)
        {
          return  await AddAsync(enrollment);
        }
    }
}
