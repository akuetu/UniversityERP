using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;

namespace Enrollment.Services
{
    public class UserEnrollmentService: IUserEnrollmentService
    {
        private readonly IUserEnrollmentRepository _userEnrollmentRepository;

        public UserEnrollmentService(IUserEnrollmentRepository userEnrollmentRepository)
        {
            _userEnrollmentRepository = userEnrollmentRepository;
        }


        public async Task<IReadOnlyList<UserEnrollment>> GetEnrollment()
        {
            return  await _userEnrollmentRepository.GetEnrollment();
        }

        public async Task<UserEnrollment> SaveEnrollment(UserEnrollment enrollment)
        {
            if (enrollment == null) throw new ArgumentNullException(nameof(enrollment));
    
            return await _userEnrollmentRepository.SaveEnrollment(enrollment);
        }

         
    }
}
