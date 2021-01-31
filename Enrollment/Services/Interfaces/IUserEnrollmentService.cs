using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Model.Entities;

namespace Enrollment.Services.Interfaces
{
    public interface IUserEnrollmentService
    {
        Task<List<UserEnrollment>>GetEnrollment();
        Task SaveEnrollment(UserEnrollment enrollment);
    }
}
