using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enrollment.Infrastructure.Data.FluentValidation;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Model.Entities;
using Enrollment.Services.Interfaces;
using FluentValidation.Results;

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

        public async Task<UserEnrollment> SaveEnrollment(UserEnrollment userEnrollment)
        {
            var validator = new ValidateUserEnrollment();
            var results = await validator.ValidateAsync(userEnrollment);

            if (!results.IsValid)
            {
                throw new Exception(results.ToString());
            }

            //if (!results.IsValid)
            //{
            //    var errorMessages = results.Errors.Select(failure => "Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage).ToList();

            //    throw new Exception(errorMessages.ToString());
            //}


            if (userEnrollment == null) throw new ArgumentNullException(nameof(userEnrollment));
    
            return await _userEnrollmentRepository.SaveEnrollment(userEnrollment);
        }

         
    }
}
