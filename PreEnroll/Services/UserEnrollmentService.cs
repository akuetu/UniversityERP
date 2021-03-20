using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.FluentValidation;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using PreEnroll.Model.Entities;

namespace Enrollment.Services
{
    public class UserEnrollmentService: IUserEnrollmentService
    {
        private readonly IUserEnrollmentRepository _userEnrollmentRepository;

        public UserEnrollmentService(IUserEnrollmentRepository userEnrollmentRepository)
        {
            _userEnrollmentRepository = userEnrollmentRepository;
        }


        public async Task<IEnumerable<UserEnrollment>> GetEnrollment()
        {
            return  await _userEnrollmentRepository.GetEnrollment();
        }

        public async Task<IEnumerable<EnrollmentViewModel>> GetAllEnrollment()
        {
            return await _userEnrollmentRepository.GetAllEnrollment();
        }

        public async Task<UserEnrollment> SaveEnrollment(UserEnrollment userEnrollment)
        {
            var validator = new ValidateUserEnrollment();
            var results = await validator.ValidateAsync(userEnrollment);

            if (!results.IsValid)
            {
                throw new Exception(results.ToString());
            }


            if (userEnrollment == null) throw new ArgumentNullException(nameof(userEnrollment));
    
            return await _userEnrollmentRepository.SaveEnrollment(userEnrollment);
        }

         
    }
}
