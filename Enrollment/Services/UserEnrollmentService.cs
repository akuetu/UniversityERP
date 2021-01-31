using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;

namespace Enrollment.Services
{
    public class UserEnrollmentService: IUserEnrollment
    {
        private readonly IUserEnrollmentRepository _userEnrollmentRepository;

        public UserEnrollmentService(IUserEnrollmentRepository userEnrollmentRepository)
        {
            _userEnrollmentRepository = userEnrollmentRepository;
        }
        public Task SaveEnrollment(UserEnrollment enrollment)
        {
            return _userEnrollmentRepository.SaveEnrollment(enrollment);
        }

         
    }
}
