using System.Threading.Tasks;
using Enrollment.Model.Entities;

namespace Enrollment.Infrastructure.Data.Interfaces
{
    public interface IUserEnrollmentRepository
    {
        Task SaveEnrollment(UserEnrollment enrollment);
    }
}
