using System;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.Base;
using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;

namespace Enrollment.Infrastructure.Data.Repository
{
    public class UserEnrollmentRepository: BaseRepository<UserEnrollment>, IUserEnrollmentRepository
    {
        private new readonly EnrollmentContext _dbContext;


        public UserEnrollmentRepository(EnrollmentContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

       
        public async Task SaveEnrollment(UserEnrollment enrollment)
        {
            // await _dbContext.UserEnrollment.AddAsync(enrollment);
              
        }
    }
}
