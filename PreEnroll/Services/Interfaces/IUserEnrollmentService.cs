using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Model.Entities;
using PreEnroll.Model.Entities;

namespace Enrollment.Services.Interfaces
{
    public interface IUserEnrollmentService
    {
        Task<IEnumerable<UserEnrollment>>GetEnrollment();
        Task<IEnumerable<EnrollmentViewModel>>GetAllEnrollment();
        Task<UserEnrollment> SaveEnrollment(UserEnrollment enrollment);
        FormEnrollmentModel GetFormEnrollment();
        Task<int> SaveEnrollmentTransaction(UserEnrollment userEnrollment);
    }
}
