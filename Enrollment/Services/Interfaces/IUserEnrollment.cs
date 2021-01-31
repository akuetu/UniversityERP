using System.Threading.Tasks;
using Enrollment.Model.Entities;

namespace Enrollment.Services.Interfaces
{
    public interface IUserEnrollment
    {
        Task SaveEnrollment(UserEnrollment enrollment);
    }
}
