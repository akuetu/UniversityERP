using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Model.Entities;
using PreEnroll.Model.Entities;

namespace Enrollment.Infrastructure.Data.Interfaces
{
    public interface IUserEnrollmentRepository
    {
        Task<IEnumerable<UserEnrollment>> GetEnrollment();

        Task<IEnumerable<EnrollmentViewModel>> GetAllEnrollment();

        Task<UserEnrollment> SaveEnrollment(UserEnrollment enrollment);

        Task<int> SaveEnrollmentTransaction(UserEnrollment enrollment);

        FormEnrollmentModel GetFormEnrollment();
    }
}
